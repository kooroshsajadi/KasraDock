namespace DockerTest
{
    partial class FrmMain
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
            this.DataGridViewContainers = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelDockerAddress = new System.Windows.Forms.Label();
            this.TxtBxDockerAddress = new System.Windows.Forms.TextBox();
            this.BtnUpdateLists = new System.Windows.Forms.Button();
            this.BtnAddTarFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewContainers)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewContainers
            // 
            this.DataGridViewContainers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridViewContainers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewContainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewContainers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Image});
            this.DataGridViewContainers.Location = new System.Drawing.Point(13, 37);
            this.DataGridViewContainers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataGridViewContainers.Name = "DataGridViewContainers";
            this.DataGridViewContainers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DataGridViewContainers.RowHeadersVisible = false;
            this.DataGridViewContainers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewContainers.Size = new System.Drawing.Size(675, 453);
            this.DataGridViewContainers.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.HeaderText = "نام container";
            this.Name.MinimumWidth = 337;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 337;
            // 
            // Image
            // 
            this.Image.HeaderText = "نام image";
            this.Image.MinimumWidth = 337;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 337;
            // 
            // LabelDockerAddress
            // 
            this.LabelDockerAddress.AutoSize = true;
            this.LabelDockerAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LabelDockerAddress.Location = new System.Drawing.Point(630, 9);
            this.LabelDockerAddress.Name = "LabelDockerAddress";
            this.LabelDockerAddress.Size = new System.Drawing.Size(59, 14);
            this.LabelDockerAddress.TabIndex = 10;
            this.LabelDockerAddress.Text = "آدرس داکر";
            // 
            // TxtBxDockerAddress
            // 
            this.TxtBxDockerAddress.Location = new System.Drawing.Point(305, 6);
            this.TxtBxDockerAddress.Name = "TxtBxDockerAddress";
            this.TxtBxDockerAddress.Size = new System.Drawing.Size(318, 23);
            this.TxtBxDockerAddress.TabIndex = 11;
            // 
            // BtnUpdateLists
            // 
            this.BtnUpdateLists.Location = new System.Drawing.Point(229, 5);
            this.BtnUpdateLists.Name = "BtnUpdateLists";
            this.BtnUpdateLists.Size = new System.Drawing.Size(75, 25);
            this.BtnUpdateLists.TabIndex = 12;
            this.BtnUpdateLists.Text = "جست و جو";
            this.BtnUpdateLists.UseVisualStyleBackColor = true;
            this.BtnUpdateLists.Click += new System.EventHandler(this.BtnUpdateLists_Click);
            // 
            // BtnAddTarFile
            // 
            this.BtnAddTarFile.Location = new System.Drawing.Point(12, 496);
            this.BtnAddTarFile.Name = "BtnAddTarFile";
            this.BtnAddTarFile.Size = new System.Drawing.Size(75, 25);
            this.BtnAddTarFile.TabIndex = 13;
            this.BtnAddTarFile.Text = "اضافه";
            this.BtnAddTarFile.UseVisualStyleBackColor = true;
            this.BtnAddTarFile.Click += new System.EventHandler(this.BtnAddTarFile_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(701, 533);
            this.Controls.Add(this.BtnAddTarFile);
            this.Controls.Add(this.BtnUpdateLists);
            this.Controls.Add(this.TxtBxDockerAddress);
            this.Controls.Add(this.LabelDockerAddress);
            this.Controls.Add(this.DataGridViewContainers);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            //this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "KasraDock";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewContainers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewContainers;
        private System.Windows.Forms.Label LabelDockerAddress;
        private System.Windows.Forms.TextBox TxtBxDockerAddress;
        private System.Windows.Forms.Button BtnUpdateLists;
        private System.Windows.Forms.Button BtnAddTarFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
    }
}