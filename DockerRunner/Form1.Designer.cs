namespace DockerRunner
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRemoveAllImages = new System.Windows.Forms.Button();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDockerFileLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.NumericUpDown();
            this.btnBuildDockerImage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImageName = new System.Windows.Forms.TextBox();
            this.ucImages2 = new DockerRunner.UC.UCImages();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOutSidePort = new System.Windows.Forms.NumericUpDown();
            this.txtInsidePort = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContainerName = new System.Windows.Forms.TextBox();
            this.ucImageContainer = new DockerRunner.UC.UCImages();
            this.btnContainerCreate = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ucLogg1 = new DockerRunner.UC.UCLogg();
            this.ucContainer1 = new DockerRunner.UC.UCContainer();
            this.btnRunImage = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPullImage = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTag)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutSidePort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInsidePort)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(709, 193);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPullImage);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnRemoveAllImages);
            this.tabPage1.Controls.Add(this.btnRemoveImage);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.ucImages2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(701, 167);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IMAGES";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAllImages
            // 
            this.btnRemoveAllImages.Location = new System.Drawing.Point(344, 35);
            this.btnRemoveAllImages.Name = "btnRemoveAllImages";
            this.btnRemoveAllImages.Size = new System.Drawing.Size(158, 23);
            this.btnRemoveAllImages.TabIndex = 11;
            this.btnRemoveAllImages.Text = "REMOVE ALL IMAGES";
            this.btnRemoveAllImages.UseVisualStyleBackColor = true;
            this.btnRemoveAllImages.Click += new System.EventHandler(this.BtnRemoveAllImages_Click);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Location = new System.Drawing.Point(344, 6);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(158, 23);
            this.btnRemoveImage.TabIndex = 10;
            this.btnRemoveImage.Text = "REMOVE IMAGE";
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            this.btnRemoveImage.Click += new System.EventHandler(this.BtnRemoveImage_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDockerFileLocation);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtTag);
            this.groupBox3.Controls.Add(this.btnBuildDockerImage);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtImageName);
            this.groupBox3.Location = new System.Drawing.Point(6, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(701, 70);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DOCKER FILE TO IMAGE";
            // 
            // txtDockerFileLocation
            // 
            this.txtDockerFileLocation.Location = new System.Drawing.Point(37, 33);
            this.txtDockerFileLocation.Name = "txtDockerFileLocation";
            this.txtDockerFileLocation.Size = new System.Drawing.Size(145, 20);
            this.txtDockerFileLocation.TabIndex = 1;
            this.txtDockerFileLocation.Text = "E:\\docker\\API";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(366, 33);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(120, 20);
            this.txtTag.TabIndex = 7;
            this.txtTag.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBuildDockerImage
            // 
            this.btnBuildDockerImage.Location = new System.Drawing.Point(509, 33);
            this.btnBuildDockerImage.Name = "btnBuildDockerImage";
            this.btnBuildDockerImage.Size = new System.Drawing.Size(121, 23);
            this.btnBuildDockerImage.TabIndex = 2;
            this.btnBuildDockerImage.Text = "Build Docker File";
            this.btnBuildDockerImage.UseVisualStyleBackColor = true;
            this.btnBuildDockerImage.Click += new System.EventHandler(this.BtnBuildDockerImage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Image Name";
            // 
            // txtImageName
            // 
            this.txtImageName.Location = new System.Drawing.Point(213, 33);
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(134, 20);
            this.txtImageName.TabIndex = 4;
            // 
            // ucImages2
            // 
            this.ucImages2.Location = new System.Drawing.Point(8, 6);
            this.ucImages2.Name = "ucImages2";
            this.ucImages2.Size = new System.Drawing.Size(330, 45);
            this.ucImages2.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRemove);
            this.tabPage2.Controls.Add(this.btnStop);
            this.tabPage2.Controls.Add(this.btnRunImage);
            this.tabPage2.Controls.Add(this.ucContainer1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(701, 167);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CONTAINER";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOutSidePort);
            this.groupBox1.Controls.Add(this.txtInsidePort);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtContainerName);
            this.groupBox1.Controls.Add(this.ucImageContainer);
            this.groupBox1.Controls.Add(this.btnContainerCreate);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 91);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CREATE";
            // 
            // txtOutSidePort
            // 
            this.txtOutSidePort.Location = new System.Drawing.Point(448, 46);
            this.txtOutSidePort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtOutSidePort.Name = "txtOutSidePort";
            this.txtOutSidePort.Size = new System.Drawing.Size(76, 20);
            this.txtOutSidePort.TabIndex = 8;
            // 
            // txtInsidePort
            // 
            this.txtInsidePort.Location = new System.Drawing.Point(369, 45);
            this.txtInsidePort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtInsidePort.Name = "txtInsidePort";
            this.txtInsidePort.Size = new System.Drawing.Size(73, 20);
            this.txtInsidePort.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "OUTSIDE PORT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "INSIDE PORT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CONTAINER NAME";
            // 
            // txtContainerName
            // 
            this.txtContainerName.Location = new System.Drawing.Point(262, 45);
            this.txtContainerName.Name = "txtContainerName";
            this.txtContainerName.Size = new System.Drawing.Size(101, 20);
            this.txtContainerName.TabIndex = 3;
            // 
            // ucImageContainer
            // 
            this.ucImageContainer.Location = new System.Drawing.Point(6, 19);
            this.ucImageContainer.Name = "ucImageContainer";
            this.ucImageContainer.Size = new System.Drawing.Size(250, 47);
            this.ucImageContainer.TabIndex = 2;
            // 
            // btnContainerCreate
            // 
            this.btnContainerCreate.Location = new System.Drawing.Point(561, 10);
            this.btnContainerCreate.Name = "btnContainerCreate";
            this.btnContainerCreate.Size = new System.Drawing.Size(124, 23);
            this.btnContainerCreate.TabIndex = 1;
            this.btnContainerCreate.Text = "CREATE CONTAINER";
            this.btnContainerCreate.UseVisualStyleBackColor = true;
            this.btnContainerCreate.Click += new System.EventHandler(this.BtnContainerCreate_Click);
            // 
            // ucLogg1
            // 
            this.ucLogg1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucLogg1.Location = new System.Drawing.Point(0, 195);
            this.ucLogg1.Name = "ucLogg1";
            this.ucLogg1.Size = new System.Drawing.Size(709, 255);
            this.ucLogg1.TabIndex = 3;
            // 
            // ucContainer1
            // 
            this.ucContainer1.Location = new System.Drawing.Point(23, 103);
            this.ucContainer1.Name = "ucContainer1";
            this.ucContainer1.Size = new System.Drawing.Size(258, 45);
            this.ucContainer1.TabIndex = 16;
            // 
            // btnRunImage
            // 
            this.btnRunImage.Location = new System.Drawing.Point(299, 125);
            this.btnRunImage.Name = "btnRunImage";
            this.btnRunImage.Size = new System.Drawing.Size(75, 23);
            this.btnRunImage.TabIndex = 17;
            this.btnRunImage.Text = "RUN";
            this.btnRunImage.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(377, 125);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 18;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(456, 125);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "DOCKER PUSH";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPullImage
            // 
            this.btnPullImage.Location = new System.Drawing.Point(509, 37);
            this.btnPullImage.Name = "btnPullImage";
            this.btnPullImage.Size = new System.Drawing.Size(173, 23);
            this.btnPullImage.TabIndex = 13;
            this.btnPullImage.Text = "PULL IMAGE";
            this.btnPullImage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.ucLogg1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "DOCKER RUNNER";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTag)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutSidePort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInsidePort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtDockerFileLocation;
        private System.Windows.Forms.Button btnBuildDockerImage;
        private System.Windows.Forms.TextBox txtImageName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtTag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnContainerCreate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UC.UCImages ucImageContainer;
        private UC.UCImages ucImages2;
        private System.Windows.Forms.Button btnRemoveAllImages;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.GroupBox groupBox3;
        private UC.UCLogg ucLogg1;
        private System.Windows.Forms.TextBox txtContainerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtInsidePort;
        private System.Windows.Forms.NumericUpDown txtOutSidePort;
        private UC.UCContainer ucContainer1;
        private System.Windows.Forms.Button btnRunImage;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPullImage;
    }
}

