using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Docker.DotNet;
using Docker.DotNet.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DockerTest
{
    public partial class FrmDockerManager : Form
    {
        private DockerClient _sourceDockerClient;

        private string _configFilePath =
            @"C:\Users\ksajadi\Desktop\kasracontainerhost-master\KasraContainerHost\bin\Debug\Resources\configuration.json";
        private JObject _configuration;
        public FrmDockerManager(string dockerAddress)
        {
            InitializeComponent();
            _sourceDockerClient = new DockerClientConfiguration(new Uri($"http://{dockerAddress}")).CreateClient();
            TxtBxConfigFilePath.Text = _configFilePath;
            _configuration = JObject.Parse(File.ReadAllText(_configFilePath));
        }


        private void BtnVolumeSearch_Click(object sender, EventArgs e)
        {
            var result = FolderBrowserDialogSearch.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            TxtBxVolume.Text = FolderBrowserDialogSearch.SelectedPath;
        }

        private async void AddImage()
        {
            var progress = new Progress<JSONMessage>();
            var imageFileStream = new FileStream(TxtBxImagePath.Text, FileMode.Open);
            await _sourceDockerClient.Images.LoadImageAsync(new ImageLoadParameters() { Quiet = false }, imageFileStream,
                progress);
        }
        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (InvokeRequired)
                {

                    Invoke(new MethodInvoker(delegate { Enabled = false; }));
                }

                else
                {
                    Enabled = false;
                }

                _configFilePath = TxtBxConfigFilePath.Text;
                _configuration = JObject.Parse(File.ReadAllText(_configFilePath));
                AddImage();

                foreach (var dockerImage in _configuration["docker-images"])
                {
                    var configCollection =
                        JsonConvert.DeserializeObject<Dictionary<string, string>>(
                            dockerImage["environment-variables"].ToString());

                    configCollection["Hangfire_DataSource"] = TxtBxServerAddress.Text;
                    configCollection["Hangfire_DBUsername"] = TxtBxUsername.Text;
                    configCollection["Hangfire_DBPassword"] = TxtBxPassword.Text;

                    var environmentVariables = configCollection.Select(x => $"{x.Key}={x.Value}").ToList();

                    configCollection["host"] = TxtBxVolume.Text;


                    var containers = await _sourceDockerClient.Containers
                        .ListContainersAsync(new ContainersListParameters() { All = true }).ConfigureAwait(false);

                    var currentContainers = containers.Where(x => x.Names.Any(c => c.Equals("/" + dockerImage["imageName"])))
                        .ToList();

                    foreach (var container in currentContainers)
                    {
                        await _sourceDockerClient.Containers.RemoveContainerAsync(container.ID,
                            new ContainerRemoveParameters() { Force = true });
                    }

                    var exposedPorts = new Dictionary<string, EmptyStruct>();
                    var portBindings = new Dictionary<string, IList<PortBinding>>();
                    foreach (var port in dockerImage["ports"].ToList())
                    {
                        exposedPorts.Add(port["container"].Value<string>(), default);
                        portBindings.Add(port["container"].Value<string>(),
                            new List<PortBinding>() { new PortBinding() { HostPort = port["host"].Value<string>() } });
                    }

                    var volumes = new Dictionary<string, EmptyStruct> { { "/data/test", default } };
                    var parameters = new CreateContainerParameters()
                    {

                        Image = $"{dockerImage["repositoryName"]}/{dockerImage["imageName"]}",
                        ArgsEscaped = false,
                        AttachStderr = false,
                        AttachStdin = false,
                        AttachStdout = true,
                        Name = dockerImage["imageName"].Value<string>(),
                        ExposedPorts = exposedPorts,
                        HostConfig = new HostConfig
                        {
                            PortBindings = portBindings,
                            RestartPolicy = JsonConvert.DeserializeObject<RestartPolicy>(dockerImage["restart-policy"].ToString()),
                            Binds = new List<string>() { @"C:\Users\ksajadi\Desktop\kasracontainerhost-master\KasraContainerHost\Properties:/data/test" },
                        },
                        Env = environmentVariables,
                        Volumes = volumes
                    };
                    var response =
                        await _sourceDockerClient.Containers.CreateContainerAsync(parameters);
                    await _sourceDockerClient.Containers.StartContainerAsync(response.ID, new ContainerStartParameters());
                }

                if (InvokeRequired)
                {

                    Invoke(new MethodInvoker(delegate { Enabled = true; }));
                }

                else
                {
                    Enabled = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //private string GetIp()
        //{
        //    var hostName = Dns.GetHostName(); 
        //    var myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
        //    return myIP;
        //}

        private void BtnImageSearch_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = @"tar files (*.tar)|*.tar";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TxtBxImagePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void BtnConfigFileSearch_Click(object sender, EventArgs e)
        {
            var result = FolderBrowserDialogSearch.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            TxtBxConfigFilePath.Text = FolderBrowserDialogSearch.SelectedPath;
        }
    }
}
