namespace DockerRunner.UC
{
    partial class UCContainer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReloadContainers = new System.Windows.Forms.Button();
            this.cmbContainers = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkAllImages = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "CONTAINERS";
            // 
            // btnReloadContainers
            // 
            this.btnReloadContainers.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReloadContainers.Location = new System.Drawing.Point(183, 0);
            this.btnReloadContainers.Name = "btnReloadContainers";
            this.btnReloadContainers.Size = new System.Drawing.Size(75, 24);
            this.btnReloadContainers.TabIndex = 24;
            this.btnReloadContainers.Text = "RELOAD";
            this.btnReloadContainers.UseVisualStyleBackColor = true;
            this.btnReloadContainers.Click += new System.EventHandler(this.BtnReloadContainers_Click);
            // 
            // cmbContainers
            // 
            this.cmbContainers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbContainers.FormattingEnabled = true;
            this.cmbContainers.Location = new System.Drawing.Point(0, 24);
            this.cmbContainers.Name = "cmbContainers";
            this.cmbContainers.Size = new System.Drawing.Size(258, 21);
            this.cmbContainers.TabIndex = 23;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // chkAllImages
            // 
            this.chkAllImages.AutoSize = true;
            this.chkAllImages.Location = new System.Drawing.Point(83, 3);
            this.chkAllImages.Name = "chkAllImages";
            this.chkAllImages.Size = new System.Drawing.Size(45, 17);
            this.chkAllImages.TabIndex = 26;
            this.chkAllImages.Text = "ALL";
            this.chkAllImages.UseVisualStyleBackColor = true;
            // 
            // UCContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkAllImages);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReloadContainers);
            this.Controls.Add(this.cmbContainers);
            this.Name = "UCContainer";
            this.Size = new System.Drawing.Size(258, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReloadContainers;
        private System.Windows.Forms.ComboBox cmbContainers;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkAllImages;
    }
}
