using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Docker.DotNet;
using Docker.DotNet.Models;
using DockerTest.Models;

namespace DockerTest
{
    public partial class FrmMain : Form
    {
        private DockerClient _sourceDockerClient;
        private IList<ContainerListResponse> _containers;
        public FrmMain()
        {
            InitializeComponent();
            TxtBxDockerAddress.Text = @"127.0.0.1:2375";
            BindToOriginContainersCombo();
        }

        private void BtnUpdateLists_Click(object sender, EventArgs e)
        {
            Enabled = false;
            BindToOriginContainersCombo();
            Enabled = true;
        }
        private async void BindToOriginContainersCombo()
        {
            try
            {
                _sourceDockerClient = new DockerClientConfiguration(new Uri($"http://{TxtBxDockerAddress.Text}"))
                    .CreateClient();
                _containers =
                    await _sourceDockerClient.Containers.ListContainersAsync(new ContainersListParameters {All = true});
                var containerList = _containers.Select(container => new ContainerModel
                {
                    Name = container.Names[0].Replace("/", ""),
                    Image = container.Image
                }).ToList();
                DataGridViewContainers.Rows.Clear();
                foreach (var container in containerList)
                {
                    DataGridViewContainers.Rows.Add(container.Name, container.Image);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().Contains("connection failed"))
                {
                    MessageBox.Show(this, @"عدم امکان اتصال", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this, ex.Message, @"خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnAddTarFile_Click(object sender, EventArgs e)
        {
            var imageAdditionForm = new FrmDockerManager(TxtBxDockerAddress.Text)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            imageAdditionForm.ShowDialog();
        }
    }
}
