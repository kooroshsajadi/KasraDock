namespace DockerTest
{
    partial class FrmDockerManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelVolume = new System.Windows.Forms.Label();
            this.TxtBxVolume = new System.Windows.Forms.TextBox();
            this.BtnVolumeSearch = new System.Windows.Forms.Button();
            this.GroupBxEnvVars = new System.Windows.Forms.GroupBox();
            this.TxtBxPassword = new System.Windows.Forms.TextBox();
            this.TxtBxUsername = new System.Windows.Forms.TextBox();
            this.TxtBxServerAddress = new System.Windows.Forms.TextBox();
            this.LabelPasword = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelServerAddress = new System.Windows.Forms.Label();
            this.TxtBxImagePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnImageSearch = new System.Windows.Forms.Button();
            this.FolderBrowserDialogSearch = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.GroupBoxPaths = new System.Windows.Forms.GroupBox();
            this.BtnConfigFileSearch = new System.Windows.Forms.Button();
            this.TxtBxConfigFilePath = new System.Windows.Forms.TextBox();
            this.LabelConfigFilePath = new System.Windows.Forms.Label();
            this.GroupBxEnvVars.SuspendLayout();
            this.GroupBoxPaths.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelVolume
            // 
            this.LabelVolume.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelVolume.AutoSize = true;
            this.LabelVolume.Location = new System.Drawing.Point(565, 110);
            this.LabelVolume.Name = "LabelVolume";
            this.LabelVolume.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelVolume.Size = new System.Drawing.Size(39, 14);
            this.LabelVolume.TabIndex = 11;
            this.LabelVolume.Text = "حافظه";
            // 
            // TxtBxVolume
            // 
            this.TxtBxVolume.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtBxVolume.Location = new System.Drawing.Point(24, 108);
            this.TxtBxVolume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBxVolume.Name = "TxtBxVolume";
            this.TxtBxVolume.Size = new System.Drawing.Size(510, 23);
            this.TxtBxVolume.TabIndex = 12;
            this.TxtBxVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnVolumeSearch
            // 
            this.BtnVolumeSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnVolumeSearch.Location = new System.Drawing.Point(2, 107);
            this.BtnVolumeSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnVolumeSearch.Name = "BtnVolumeSearch";
            this.BtnVolumeSearch.Size = new System.Drawing.Size(23, 25);
            this.BtnVolumeSearch.TabIndex = 13;
            this.BtnVolumeSearch.Text = "-";
            this.BtnVolumeSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnVolumeSearch.UseVisualStyleBackColor = true;
            this.BtnVolumeSearch.Click += new System.EventHandler(this.BtnVolumeSearch_Click);
            // 
            // GroupBxEnvVars
            // 
            this.GroupBxEnvVars.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GroupBxEnvVars.Controls.Add(this.TxtBxPassword);
            this.GroupBxEnvVars.Controls.Add(this.TxtBxUsername);
            this.GroupBxEnvVars.Controls.Add(this.TxtBxServerAddress);
            this.GroupBxEnvVars.Controls.Add(this.BtnVolumeSearch);
            this.GroupBxEnvVars.Controls.Add(this.LabelPasword);
            this.GroupBxEnvVars.Controls.Add(this.TxtBxVolume);
            this.GroupBxEnvVars.Controls.Add(this.LabelUsername);
            this.GroupBxEnvVars.Controls.Add(this.LabelVolume);
            this.GroupBxEnvVars.Controls.Add(this.LabelServerAddress);
            this.GroupBxEnvVars.Location = new System.Drawing.Point(10, 119);
            this.GroupBxEnvVars.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBxEnvVars.Name = "GroupBxEnvVars";
            this.GroupBxEnvVars.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBxEnvVars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBxEnvVars.Size = new System.Drawing.Size(611, 143);
            this.GroupBxEnvVars.TabIndex = 14;
            this.GroupBxEnvVars.TabStop = false;
            this.GroupBxEnvVars.Text = "تنظیمات";
            // 
            // TxtBxPassword
            // 
            this.TxtBxPassword.Location = new System.Drawing.Point(257, 77);
            this.TxtBxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBxPassword.Name = "TxtBxPassword";
            this.TxtBxPassword.PasswordChar = '*';
            this.TxtBxPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtBxPassword.Size = new System.Drawing.Size(277, 23);
            this.TxtBxPassword.TabIndex = 20;
            this.TxtBxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtBxUsername
            // 
            this.TxtBxUsername.Location = new System.Drawing.Point(257, 48);
            this.TxtBxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBxUsername.Name = "TxtBxUsername";
            this.TxtBxUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtBxUsername.Size = new System.Drawing.Size(277, 23);
            this.TxtBxUsername.TabIndex = 19;
            this.TxtBxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtBxServerAddress
            // 
            this.TxtBxServerAddress.Location = new System.Drawing.Point(257, 19);
            this.TxtBxServerAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBxServerAddress.Name = "TxtBxServerAddress";
            this.TxtBxServerAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtBxServerAddress.Size = new System.Drawing.Size(277, 23);
            this.TxtBxServerAddress.TabIndex = 18;
            this.TxtBxServerAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelPasword
            // 
            this.LabelPasword.AutoSize = true;
            this.LabelPasword.Location = new System.Drawing.Point(549, 80);
            this.LabelPasword.Name = "LabelPasword";
            this.LabelPasword.Size = new System.Drawing.Size(55, 14);
            this.LabelPasword.TabIndex = 17;
            this.LabelPasword.Text = "کلمه عبور";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(548, 51);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(57, 14);
            this.LabelUsername.TabIndex = 16;
            this.LabelUsername.Text = "نام کاربری";
            // 
            // LabelServerAddress
            // 
            this.LabelServerAddress.AutoSize = true;
            this.LabelServerAddress.Location = new System.Drawing.Point(540, 22);
            this.LabelServerAddress.Name = "LabelServerAddress";
            this.LabelServerAddress.Size = new System.Drawing.Size(65, 14);
            this.LabelServerAddress.TabIndex = 15;
            this.LabelServerAddress.Text = "آدرس سرور";
            // 
            // TxtBxImagePath
            // 
            this.TxtBxImagePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtBxImagePath.Location = new System.Drawing.Point(28, 25);
            this.TxtBxImagePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBxImagePath.Name = "TxtBxImagePath";
            this.TxtBxImagePath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtBxImagePath.Size = new System.Drawing.Size(466, 23);
            this.TxtBxImagePath.TabIndex = 16;
            this.TxtBxImagePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 29);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "آدرس Image";
            // 
            // BtnImageSearch
            // 
            this.BtnImageSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnImageSearch.Location = new System.Drawing.Point(6, 24);
            this.BtnImageSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnImageSearch.Name = "BtnImageSearch";
            this.BtnImageSearch.Size = new System.Drawing.Size(23, 25);
            this.BtnImageSearch.TabIndex = 17;
            this.BtnImageSearch.Text = "-";
            this.BtnImageSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnImageSearch.UseVisualStyleBackColor = true;
            this.BtnImageSearch.Click += new System.EventHandler(this.BtnImageSearch_Click);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(12, 496);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(87, 24);
            this.BtnSubmit.TabIndex = 18;
            this.BtnSubmit.Text = "شروع";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // GroupBoxPaths
            // 
            this.GroupBoxPaths.Controls.Add(this.BtnConfigFileSearch);
            this.GroupBoxPaths.Controls.Add(this.TxtBxConfigFilePath);
            this.GroupBoxPaths.Controls.Add(this.LabelConfigFilePath);
            this.GroupBoxPaths.Controls.Add(this.label1);
            this.GroupBoxPaths.Controls.Add(this.BtnImageSearch);
            this.GroupBoxPaths.Controls.Add(this.TxtBxImagePath);
            this.GroupBoxPaths.Location = new System.Drawing.Point(10, 12);
            this.GroupBoxPaths.Name = "GroupBoxPaths";
            this.GroupBoxPaths.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBoxPaths.Size = new System.Drawing.Size(611, 100);
            this.GroupBoxPaths.TabIndex = 19;
            this.GroupBoxPaths.TabStop = false;
            this.GroupBoxPaths.Text = "مسیر";
            // 
            // BtnConfigFileSearch
            // 
            this.BtnConfigFileSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnConfigFileSearch.Location = new System.Drawing.Point(6, 60);
            this.BtnConfigFileSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnConfigFileSearch.Name = "BtnConfigFileSearch";
            this.BtnConfigFileSearch.Size = new System.Drawing.Size(23, 25);
            this.BtnConfigFileSearch.TabIndex = 20;
            this.BtnConfigFileSearch.Text = "-";
            this.BtnConfigFileSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnConfigFileSearch.UseVisualStyleBackColor = true;
            this.BtnConfigFileSearch.Click += new System.EventHandler(this.BtnConfigFileSearch_Click);
            // 
            // TxtBxConfigFilePath
            // 
            this.TxtBxConfigFilePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtBxConfigFilePath.Location = new System.Drawing.Point(28, 61);
            this.TxtBxConfigFilePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBxConfigFilePath.Name = "TxtBxConfigFilePath";
            this.TxtBxConfigFilePath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtBxConfigFilePath.Size = new System.Drawing.Size(466, 23);
            this.TxtBxConfigFilePath.TabIndex = 19;
            this.TxtBxConfigFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelConfigFilePath
            // 
            this.LabelConfigFilePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelConfigFilePath.AutoSize = true;
            this.LabelConfigFilePath.Location = new System.Drawing.Point(500, 64);
            this.LabelConfigFilePath.Name = "LabelConfigFilePath";
            this.LabelConfigFilePath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelConfigFilePath.Size = new System.Drawing.Size(104, 14);
            this.LabelConfigFilePath.TabIndex = 18;
            this.LabelConfigFilePath.Text = "آدرس فایل تنظیمات";
            // 
            // FrmDockerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 533);
            this.Controls.Add(this.GroupBoxPaths);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.GroupBxEnvVars);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDockerManager";
            this.ShowIcon = false;
            this.GroupBxEnvVars.ResumeLayout(false);
            this.GroupBxEnvVars.PerformLayout();
            this.GroupBoxPaths.ResumeLayout(false);
            this.GroupBoxPaths.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LabelVolume;
        private System.Windows.Forms.TextBox TxtBxVolume;
        private System.Windows.Forms.Button BtnVolumeSearch;
        private System.Windows.Forms.GroupBox GroupBxEnvVars;
        private System.Windows.Forms.Label LabelPasword;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelServerAddress;
        private System.Windows.Forms.TextBox TxtBxServerAddress;
        private System.Windows.Forms.TextBox TxtBxPassword;
        private System.Windows.Forms.TextBox TxtBxUsername;
        private System.Windows.Forms.TextBox TxtBxImagePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnImageSearch;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialogSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.GroupBox GroupBoxPaths;
        private System.Windows.Forms.Button BtnConfigFileSearch;
        private System.Windows.Forms.TextBox TxtBxConfigFilePath;
        private System.Windows.Forms.Label LabelConfigFilePath;
    }
}

