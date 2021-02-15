using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Net;
using System.Windows.Forms;
using Docker.DotNet;
using Docker.DotNet.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DockerTest
{
    public partial class FrmDockerManager : Form
    {
        private readonly string _imagePath = @"C:\Users\ksajadi\Desktop\kasracontainerhost-master\KasraContainerHost\bin\Debug\Resources\test.tar";
        private DockerClient _sourceDockerClient;
        private readonly JObject _configuration;
        private IList<ContainerListResponse> _containers;
        public FrmDockerManager()
        {
            InitializeComponent();
            TxtBxDockerAddress.Text = @"localhost";
            _sourceDockerClient = new DockerClientConfiguration(new Uri($"http://{TxtBxDockerAddress.Text}:2375")).CreateClient();
            BtnUpdateLists_Click(this, EventArgs.Empty);
            _configuration = JObject.Parse(File.ReadAllText(@"C:\Users\ksajadi\Desktop\kasracontainerhost-master\KasraContainerHost\bin\Debug\Resources\configuration.json"));
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Enabled = false;
            var progress = new Progress<JSONMessage>();
            var imageFileStream = new FileStream(_imagePath, FileMode.Open);
            await _sourceDockerClient.Images.LoadImageAsync(new ImageLoadParameters() { Quiet = false },
                imageFileStream,
                progress);
            Enabled = false;
            MessageBox.Show(@"Done");
        }

        private async void GetOriginInstanceImageList()
        {
            var progress = new Progress<JSONMessage>();
            var imageFileStream = new FileStream(_imagePath, FileMode.Open);
            await _sourceDockerClient.Images.LoadImageAsync(new ImageLoadParameters() { Quiet = false }, imageFileStream,
                progress);
        }

        //private async void GetDestInstanceImageList()
        //{
        //    var progress = new Progress<JSONMessage>();
        //    var imageFileStream = new FileStream(_imagePath, FileMode.Open);
        //    await DestDockerClient.Images.LoadImageAsync(new ImageLoadParameters() { Quiet = false }, imageFileStream,
        //        progress);
        //}

        private async void BindToOriginImagesCombo()
        {
            var res = await _sourceDockerClient.Images.ListImagesAsync(new ImagesListParameters { All = true });

            var bindingSource = new BindingSource {DataSource = res.Select(item => item.RepoTags[0]).ToList()};

            ComboBxOriginImages.DataSource = bindingSource.DataSource;
        }

        private async void BindToOriginContainersCombo()
        {
            _sourceDockerClient = new DockerClientConfiguration(new Uri($"http://{TxtBxDockerAddress.Text}:2375")).CreateClient();
            _containers = await _sourceDockerClient.Containers.ListContainersAsync(new ContainersListParameters { All = true });
            var bindingSource = new BindingSource { DataSource = _containers.Select(item => item.Names[0]).ToList() };
            ComboBxOriginContainers.DataSource = bindingSource.DataSource;
        }

        //private async void BindToDestImagesCombo()
        //{
        //    var res = await DestDockerClient.Images.ListImagesAsync(new ImagesListParameters { All = true });

        //    var bindingSource = new BindingSource { DataSource = res.Select(item => item.RepoTags[0]).ToList() };

        //    ComboBxDestImages.DataSource = bindingSource.DataSource;
        //}

        private void FrmDockerManager_Load(object sender, EventArgs e)
        {
            //BindToOriginImagesCombo();
            //BindToOriginContainersCombo();
        }

        private void BtnUpdateLists_Click(object sender, EventArgs e)
        {
            Enabled = false;
            //BindToOriginImagesCombo();
            BindToOriginContainersCombo();
            Enabled = true;
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            //foreach (var dockerImage in _configuration["docker-images"])
            //{
            //    var configCollection =
            //        JsonConvert.DeserializeObject<Dictionary<string, string>>(
            //            dockerImage["environment-variables"].ToString());

            //    var t = configCollection["Hangfire_DataSource"];
            //    configCollection["Hangfire_DataSource"] = TxtBxServerAddress.Text;
            //    t = configCollection["Hangfire_DBUsername"];
            //    configCollection["Hangfire_DBUsername"] = TxtBxServerAddress.Text;
            //    t = configCollection["Hangfire_DBPassword"];
            //    configCollection["Hangfire_DBPassword"] = TxtBxServerAddress.Text;

            //    var volumes =
            //        JsonConvert.DeserializeObject<Dictionary<string, string>>(
            //            dockerImage["volumes"].ToString());

            //    var environmentVariables = volumes.Select(x => $"{x.Key}={x.Value}").ToList();
            //    t = configCollection["host"];
            //    configCollection["host"] = TxtBxServerAddress.Text;

            //    var containers = await DestDockerClient.Containers
            //        .ListContainersAsync(new ContainersListParameters() { All = true }).ConfigureAwait(false);

            //    var currentContainers = containers.Where(x => x.Names.Any(c => c.Equals("/" + dockerImage["imageName"])))
            //        .ToList();

            //    foreach (var container in currentContainers)
            //    {
            //        await DestDockerClient.Containers.RemoveContainerAsync(container.ID,
            //            new ContainerRemoveParameters() { Force = true });
            //    }

            //    var exposedPorts = new Dictionary<string, EmptyStruct>();
            //    var portBindings = new Dictionary<string, IList<PortBinding>>();
            //    foreach (var port in dockerImage["ports"].ToList())
            //    {
            //        exposedPorts.Add(port["container"].Value<string>(), default);
            //        portBindings.Add(port["container"].Value<string>(),
            //            new List<PortBinding>() { new PortBinding() { HostPort = port["host"].Value<string>() } });
            //    }

                
            //    var parameters = new CreateContainerParameters()
            //    {
            //        Image = $"{dockerImage["repositoryName"]}/{dockerImage["imageName"]}",
            //        ArgsEscaped = false,
            //        AttachStderr = false,
            //        AttachStdin = false,
            //        AttachStdout = true,
            //        Name = dockerImage["imageName"].Value<string>(),
            //        ExposedPorts = exposedPorts,
            //        HostConfig = new HostConfig
            //        {
            //            PortBindings = portBindings,
            //            RestartPolicy = JsonConvert.DeserializeObject<RestartPolicy>(dockerImage["restart-policy"].ToString())
            //        },
            //        Env = environmentVariables
            //    };
            //    var response =
            //        await DestDockerClient.Containers.CreateContainerAsync(parameters);
            //    await DestDockerClient.Containers.StartContainerAsync(response.ID, new ContainerStartParameters());
            //}
            //MessageBox.Show(@"Done");
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
            _sourceDockerClient = new DockerClientConfiguration(new Uri($"http://{TxtBxDockerAddress.Text}:2375")).CreateClient();
            var progress = new Progress<JSONMessage>();
            var imageFileStream = new FileStream(TxtBxImagePath.Text, FileMode.Open);
            await _sourceDockerClient.Images.LoadImageAsync(new ImageLoadParameters() { Quiet = false }, imageFileStream,
                progress);
        }
        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            _sourceDockerClient = new DockerClientConfiguration(new Uri($"http://{TxtBxDockerAddress.Text}:2375")).CreateClient();
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
                var volumes =
                    JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(
                        dockerImage["volumes"].ToString());
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

                var t = new Dictionary<string, EmptyStruct> {{"mine", new EmptyStruct()}};
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
                        RestartPolicy = JsonConvert.DeserializeObject<RestartPolicy>(dockerImage["restart-policy"].ToString())
                    },
                    Env = environmentVariables,
                    Volumes = t
                };
                var response =
                    await _sourceDockerClient.Containers.CreateContainerAsync(parameters);
                //var startParameters = new ContainerStartParameters()
                //{
                //    ExposedPorts = new Dictionary<string, EmptyStruct> { { "2280:80/tcp", new EmptyStruct() } }
                //};
                await _sourceDockerClient.Containers.StartContainerAsync(response.ID, new ContainerStartParameters());
            }
        }

        private string GetIp()
        {
            var hostName = Dns.GetHostName(); // Retrieve the Name of HOST  
            // Get the IP
            var myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            return myIP;
        }
        
        private async void BtnShowLog_Click(object sender, EventArgs e)
        {
            var scriptPath = $"docker logs {ComboBxOriginContainers.Text}";
            var psinstance = PowerShell.Create();
            psinstance.AddScript(scriptPath);
            var results = psinstance.Invoke();

            //var id = _containers.Single(item => item.Names[0] == ComboBxOriginContainers.Text).ID;
            //var logsParameters = new ContainerLogsParameters {ShowStderr = true,ShowStdout = true,Since = "2020/02/14",Tail = "on"};
            //var currentLog = "";
            //var result=_sourceDockerClient.Containers.GetContainerLogsAsync(id, logsParameters);
            //while (!result.IsCompleted)
            //{
            //    var test = result.Status;
            //}
            //using (var stream = _sourceDockerClient.Containers.GetContainerLogsAsync(id, logsParameters).Result)
            //{
            //    using (var reader = new StreamReader(stream))
            //    {
            //        currentLog = reader.ReadToEnd();


            //    }
            //} 
            //MessageBox.Show(currentLog);
            ////var stream =  _sourceDockerClient.Containers.GetContainerLogsAsync(id, logsParameters).Result;

        }
    }
}
