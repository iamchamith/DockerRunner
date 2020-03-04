namespace DockerRunner.UC
{
    partial class UCImages
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
            this.btnReloadImages = new System.Windows.Forms.Button();
            this.cmbImages = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "IMAGES";
            // 
            // btnReloadImages
            // 
            this.btnReloadImages.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReloadImages.Location = new System.Drawing.Point(255, 0);
            this.btnReloadImages.Name = "btnReloadImages";
            this.btnReloadImages.Size = new System.Drawing.Size(75, 24);
            this.btnReloadImages.TabIndex = 21;
            this.btnReloadImages.Text = "RELOAD";
            this.btnReloadImages.UseVisualStyleBackColor = true;
            this.btnReloadImages.Click += new System.EventHandler(this.BtnReloadImages_Click);
            // 
            // cmbImages
            // 
            this.cmbImages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbImages.FormattingEnabled = true;
            this.cmbImages.Location = new System.Drawing.Point(0, 24);
            this.cmbImages.Name = "cmbImages";
            this.cmbImages.Size = new System.Drawing.Size(330, 21);
            this.cmbImages.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // UCImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReloadImages);
            this.Controls.Add(this.cmbImages);
            this.Name = "UCImages";
            this.Size = new System.Drawing.Size(330, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReloadImages;
        private System.Windows.Forms.ComboBox cmbImages;
        private System.Windows.Forms.Timer timer1;
    }
}
