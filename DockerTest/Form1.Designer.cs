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
            this.BtnAddImage = new System.Windows.Forms.Button();
            this.ComboBxOriginImages = new System.Windows.Forms.ComboBox();
            this.LabelOriginImages = new System.Windows.Forms.Label();
            this.LabelDestImages = new System.Windows.Forms.Label();
            this.ComboBxDestImages = new System.Windows.Forms.ComboBox();
            this.BtnUpdateLists = new System.Windows.Forms.Button();
            this.LabelOriginContainers = new System.Windows.Forms.Label();
            this.ComboBxOriginContainers = new System.Windows.Forms.ComboBox();
            this.BtnCreateContainers = new System.Windows.Forms.Button();
            this.LabelDockerAddress = new System.Windows.Forms.Label();
            this.TxtBxDockerAddress = new System.Windows.Forms.TextBox();
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
            this.BtnShowLog = new System.Windows.Forms.Button();
            this.GroupBxEnvVars.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAddImage
            // 
            this.BtnAddImage.Location = new System.Drawing.Point(12, 477);
            this.BtnAddImage.Name = "BtnAddImage";
            this.BtnAddImage.Size = new System.Drawing.Size(75, 23);
            this.BtnAddImage.TabIndex = 0;
            this.BtnAddImage.Text = "Add Image";
            this.BtnAddImage.UseVisualStyleBackColor = true;
            this.BtnAddImage.Visible = false;
            this.BtnAddImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComboBxOriginImages
            // 
            this.ComboBxOriginImages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBxOriginImages.FormattingEnabled = true;
            this.ComboBxOriginImages.Location = new System.Drawing.Point(67, 372);
            this.ComboBxOriginImages.Name = "ComboBxOriginImages";
            this.ComboBxOriginImages.Size = new System.Drawing.Size(385, 21);
            this.ComboBxOriginImages.TabIndex = 1;
            this.ComboBxOriginImages.Visible = false;
            // 
            // LabelOriginImages
            // 
            this.LabelOriginImages.AutoSize = true;
            this.LabelOriginImages.Location = new System.Drawing.Point(67, 355);
            this.LabelOriginImages.Name = "LabelOriginImages";
            this.LabelOriginImages.Size = new System.Drawing.Size(115, 13);
            this.LabelOriginImages.TabIndex = 2;
            this.LabelOriginImages.Text = "Origin Instance Images";
            this.LabelOriginImages.Visible = false;
            // 
            // LabelDestImages
            // 
            this.LabelDestImages.AutoSize = true;
            this.LabelDestImages.Location = new System.Drawing.Point(64, 435);
            this.LabelDestImages.Name = "LabelDestImages";
            this.LabelDestImages.Size = new System.Drawing.Size(134, 13);
            this.LabelDestImages.TabIndex = 3;
            this.LabelDestImages.Text = "Destination Source Images";
            this.LabelDestImages.Visible = false;
            // 
            // ComboBxDestImages
            // 
            this.ComboBxDestImages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBxDestImages.FormattingEnabled = true;
            this.ComboBxDestImages.Location = new System.Drawing.Point(67, 451);
            this.ComboBxDestImages.Name = "ComboBxDestImages";
            this.ComboBxDestImages.Size = new System.Drawing.Size(385, 21);
            this.ComboBxDestImages.TabIndex = 4;
            this.ComboBxDestImages.Visible = false;
            // 
            // BtnUpdateLists
            // 
            this.BtnUpdateLists.Location = new System.Drawing.Point(12, 34);
            this.BtnUpdateLists.Name = "BtnUpdateLists";
            this.BtnUpdateLists.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateLists.TabIndex = 5;
            this.BtnUpdateLists.Text = "آپدیت لیست";
            this.BtnUpdateLists.UseVisualStyleBackColor = true;
            this.BtnUpdateLists.Click += new System.EventHandler(this.BtnUpdateLists_Click);
            // 
            // LabelOriginContainers
            // 
            this.LabelOriginContainers.AutoSize = true;
            this.LabelOriginContainers.Location = new System.Drawing.Point(314, 258);
            this.LabelOriginContainers.Name = "LabelOriginContainers";
            this.LabelOriginContainers.Size = new System.Drawing.Size(80, 13);
            this.LabelOriginContainers.TabIndex = 6;
            this.LabelOriginContainers.Text = "لیست کانتینر ها";
            // 
            // ComboBxOriginContainers
            // 
            this.ComboBxOriginContainers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBxOriginContainers.FormattingEnabled = true;
            this.ComboBxOriginContainers.Location = new System.Drawing.Point(93, 274);
            this.ComboBxOriginContainers.Name = "ComboBxOriginContainers";
            this.ComboBxOriginContainers.Size = new System.Drawing.Size(300, 21);
            this.ComboBxOriginContainers.TabIndex = 7;
            // 
            // BtnCreateContainers
            // 
            this.BtnCreateContainers.Location = new System.Drawing.Point(93, 477);
            this.BtnCreateContainers.Name = "BtnCreateContainers";
            this.BtnCreateContainers.Size = new System.Drawing.Size(99, 23);
            this.BtnCreateContainers.TabIndex = 8;
            this.BtnCreateContainers.Text = "Create Containers";
            this.BtnCreateContainers.UseVisualStyleBackColor = true;
            this.BtnCreateContainers.Visible = false;
            this.BtnCreateContainers.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LabelDockerAddress
            // 
            this.LabelDockerAddress.AutoSize = true;
            this.LabelDockerAddress.Location = new System.Drawing.Point(345, 11);
            this.LabelDockerAddress.Name = "LabelDockerAddress";
            this.LabelDockerAddress.Size = new System.Drawing.Size(53, 13);
            this.LabelDockerAddress.TabIndex = 9;
            this.LabelDockerAddress.Text = "آدرس داکر";
            // 
            // TxtBxDockerAddress
            // 
            this.TxtBxDockerAddress.Location = new System.Drawing.Point(12, 8);
            this.TxtBxDockerAddress.Name = "TxtBxDockerAddress";
            this.TxtBxDockerAddress.Size = new System.Drawing.Size(318, 20);
            this.TxtBxDockerAddress.TabIndex = 10;
            // 
            // LabelVolume
            // 
            this.LabelVolume.AutoSize = true;
            this.LabelVolume.Location = new System.Drawing.Point(361, 107);
            this.LabelVolume.Name = "LabelVolume";
            this.LabelVolume.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelVolume.Size = new System.Drawing.Size(36, 13);
            this.LabelVolume.TabIndex = 11;
            this.LabelVolume.Text = "حافظه";
            // 
            // TxtBxVolume
            // 
            this.TxtBxVolume.Location = new System.Drawing.Point(33, 104);
            this.TxtBxVolume.Name = "TxtBxVolume";
            this.TxtBxVolume.Size = new System.Drawing.Size(297, 20);
            this.TxtBxVolume.TabIndex = 12;
            // 
            // BtnVolumeSearch
            // 
            this.BtnVolumeSearch.Location = new System.Drawing.Point(12, 103);
            this.BtnVolumeSearch.Name = "BtnVolumeSearch";
            this.BtnVolumeSearch.Size = new System.Drawing.Size(20, 22);
            this.BtnVolumeSearch.TabIndex = 13;
            this.BtnVolumeSearch.Text = "-";
            this.BtnVolumeSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnVolumeSearch.UseVisualStyleBackColor = true;
            this.BtnVolumeSearch.Click += new System.EventHandler(this.BtnVolumeSearch_Click);
            // 
            // GroupBxEnvVars
            // 
            this.GroupBxEnvVars.Controls.Add(this.TxtBxPassword);
            this.GroupBxEnvVars.Controls.Add(this.TxtBxUsername);
            this.GroupBxEnvVars.Controls.Add(this.TxtBxServerAddress);
            this.GroupBxEnvVars.Controls.Add(this.LabelPasword);
            this.GroupBxEnvVars.Controls.Add(this.LabelUsername);
            this.GroupBxEnvVars.Controls.Add(this.LabelServerAddress);
            this.GroupBxEnvVars.Location = new System.Drawing.Point(12, 128);
            this.GroupBxEnvVars.Name = "GroupBxEnvVars";
            this.GroupBxEnvVars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBxEnvVars.Size = new System.Drawing.Size(381, 99);
            this.GroupBxEnvVars.TabIndex = 14;
            this.GroupBxEnvVars.TabStop = false;
            this.GroupBxEnvVars.Text = "تنظیمات";
            // 
            // TxtBxPassword
            // 
            this.TxtBxPassword.Location = new System.Drawing.Point(73, 72);
            this.TxtBxPassword.Name = "TxtBxPassword";
            this.TxtBxPassword.PasswordChar = '*';
            this.TxtBxPassword.Size = new System.Drawing.Size(238, 20);
            this.TxtBxPassword.TabIndex = 20;
            // 
            // TxtBxUsername
            // 
            this.TxtBxUsername.Location = new System.Drawing.Point(73, 43);
            this.TxtBxUsername.Name = "TxtBxUsername";
            this.TxtBxUsername.Size = new System.Drawing.Size(238, 20);
            this.TxtBxUsername.TabIndex = 19;
            // 
            // TxtBxServerAddress
            // 
            this.TxtBxServerAddress.Location = new System.Drawing.Point(73, 14);
            this.TxtBxServerAddress.Name = "TxtBxServerAddress";
            this.TxtBxServerAddress.Size = new System.Drawing.Size(238, 20);
            this.TxtBxServerAddress.TabIndex = 18;
            // 
            // LabelPasword
            // 
            this.LabelPasword.AutoSize = true;
            this.LabelPasword.Location = new System.Drawing.Point(321, 73);
            this.LabelPasword.Name = "LabelPasword";
            this.LabelPasword.Size = new System.Drawing.Size(52, 13);
            this.LabelPasword.TabIndex = 17;
            this.LabelPasword.Text = "کلمه عبور";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(317, 45);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(58, 13);
            this.LabelUsername.TabIndex = 16;
            this.LabelUsername.Text = "نام کاربری";
            // 
            // LabelServerAddress
            // 
            this.LabelServerAddress.AutoSize = true;
            this.LabelServerAddress.Location = new System.Drawing.Point(317, 17);
            this.LabelServerAddress.Name = "LabelServerAddress";
            this.LabelServerAddress.Size = new System.Drawing.Size(58, 13);
            this.LabelServerAddress.TabIndex = 15;
            this.LabelServerAddress.Text = "آدرس سرور";
            // 
            // TxtBxImagePath
            // 
            this.TxtBxImagePath.Location = new System.Drawing.Point(33, 73);
            this.TxtBxImagePath.Name = "TxtBxImagePath";
            this.TxtBxImagePath.Size = new System.Drawing.Size(297, 20);
            this.TxtBxImagePath.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 76);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "آدرس Image";
            // 
            // BtnImageSearch
            // 
            this.BtnImageSearch.Location = new System.Drawing.Point(12, 72);
            this.BtnImageSearch.Name = "BtnImageSearch";
            this.BtnImageSearch.Size = new System.Drawing.Size(20, 22);
            this.BtnImageSearch.TabIndex = 17;
            this.BtnImageSearch.Text = "-";
            this.BtnImageSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnImageSearch.UseVisualStyleBackColor = true;
            this.BtnImageSearch.Visible = false;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(12, 233);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.TabIndex = 18;
            this.BtnSubmit.Text = "شروع";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnShowLog
            // 
            this.BtnShowLog.Location = new System.Drawing.Point(12, 273);
            this.BtnShowLog.Name = "BtnShowLog";
            this.BtnShowLog.Size = new System.Drawing.Size(75, 23);
            this.BtnShowLog.TabIndex = 19;
            this.BtnShowLog.Text = "نمایش لاگ";
            this.BtnShowLog.UseVisualStyleBackColor = true;
            this.BtnShowLog.Click += new System.EventHandler(this.BtnShowLog_Click);
            // 
            // FrmDockerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 311);
            this.Controls.Add(this.BtnShowLog);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.BtnImageSearch);
            this.Controls.Add(this.TxtBxImagePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupBxEnvVars);
            this.Controls.Add(this.BtnVolumeSearch);
            this.Controls.Add(this.TxtBxVolume);
            this.Controls.Add(this.LabelVolume);
            this.Controls.Add(this.TxtBxDockerAddress);
            this.Controls.Add(this.LabelDockerAddress);
            this.Controls.Add(this.BtnCreateContainers);
            this.Controls.Add(this.ComboBxOriginContainers);
            this.Controls.Add(this.LabelOriginContainers);
            this.Controls.Add(this.BtnUpdateLists);
            this.Controls.Add(this.ComboBxDestImages);
            this.Controls.Add(this.LabelDestImages);
            this.Controls.Add(this.LabelOriginImages);
            this.Controls.Add(this.ComboBxOriginImages);
            this.Controls.Add(this.BtnAddImage);
            this.Name = "FrmDockerManager";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FrmDockerManager_Load);
            this.GroupBxEnvVars.ResumeLayout(false);
            this.GroupBxEnvVars.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddImage;
        private System.Windows.Forms.ComboBox ComboBxOriginImages;
        private System.Windows.Forms.Label LabelOriginImages;
        private System.Windows.Forms.Label LabelDestImages;
        private System.Windows.Forms.ComboBox ComboBxDestImages;
        private System.Windows.Forms.Button BtnUpdateLists;
        private System.Windows.Forms.Label LabelOriginContainers;
        private System.Windows.Forms.ComboBox ComboBxOriginContainers;
        private System.Windows.Forms.Button BtnCreateContainers;
        private System.Windows.Forms.Label LabelDockerAddress;
        private System.Windows.Forms.TextBox TxtBxDockerAddress;
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
        private System.Windows.Forms.Button BtnShowLog;
    }
}

