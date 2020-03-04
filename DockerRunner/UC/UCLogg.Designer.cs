namespace DockerRunner.UC
{
    partial class UCLogg
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
            this.txtLogger = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtLastRunCommand = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLogger
            // 
            this.txtLogger.Location = new System.Drawing.Point(0, 45);
            this.txtLogger.Name = "txtLogger";
            this.txtLogger.Size = new System.Drawing.Size(705, 239);
            this.txtLogger.TabIndex = 2;
            this.txtLogger.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(627, 45);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // txtLastRunCommand
            // 
            this.txtLastRunCommand.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLastRunCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastRunCommand.Location = new System.Drawing.Point(0, 0);
            this.txtLastRunCommand.Multiline = true;
            this.txtLastRunCommand.Name = "txtLastRunCommand";
            this.txtLastRunCommand.Size = new System.Drawing.Size(705, 39);
            this.txtLastRunCommand.TabIndex = 5;
            // 
            // UCLogg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLastRunCommand);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtLogger);
            this.Name = "UCLogg";
            this.Size = new System.Drawing.Size(705, 284);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtLogger;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtLastRunCommand;
    }
}
