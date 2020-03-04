using DockerRunner.Model;
using DockerRunner.Stages;
using DockerRunner.UC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DockerRunner
{
    delegate void SetMergerTextCallback(string text);
    public partial class Form1 : Form
    {
        #region process
        public Process _proccess;
        public Process _proccess2;
        StringBuilder output;
        public StringBuilder outputRead;
        private Process ConfigureProcess()
        {
            _proccess = new Process();
            _proccess.StartInfo.FileName = "cmd";
            _proccess.StartInfo.UseShellExecute = false;
            _proccess.StartInfo.RedirectStandardOutput = true;
            _proccess.StartInfo.RedirectStandardInput = true;
            _proccess.StartInfo.CreateNoWindow = true;
            _proccess.OutputDataReceived += p_OutputDataReceived; 
            _proccess.Start();
            return _proccess;
        }
        public  Process ConfigureProcessForRead()
        {
            _proccess2 = new Process();
            _proccess2.StartInfo.FileName = "cmd";
            _proccess2.StartInfo.UseShellExecute = false;
            _proccess2.StartInfo.RedirectStandardOutput = true;
            _proccess2.StartInfo.RedirectStandardInput = true;
            _proccess2.StartInfo.CreateNoWindow = true;
            _proccess2.OutputDataReceived += p_OutputDataReceived2;
            _proccess2.Start();
            return _proccess2;
        }
        private void Execute(string argument)
        {
            ucLogg1.SetLastRunningCommand(argument);
            var process = ConfigureProcess();
            process.StandardInput.WriteLine(argument);
            process.BeginOutputReadLine();
        }
        public void ExecuteRead(string argument)
        {
            ucLogg1.SetLastRunningCommand(argument);
            var process = ConfigureProcessForRead();
            process.StandardInput.WriteLine(argument);
            process.BeginOutputReadLine();      
        }
        private void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            output.Append(e.Data + Environment.NewLine);
            ucLogg1.Logg(output.ToString());
        }
        private void p_OutputDataReceived2(object sender, DataReceivedEventArgs e)
        {
            outputRead.Append(e.Data + Environment.NewLine);
        } 
        #endregion
        public Form1()
        {
            InitializeComponent();
            ucImageContainer.SetParent(this, new List<UCImages> { ucImages2 });
            ucImages2.SetParent(this, new List<UCImages> { ucImageContainer });
            ucContainer1.SetParent(this);
            output = new StringBuilder();
            ConfigureProcess();
        }

        private void BtnBuildDockerImage_Click(object sender, EventArgs e)
        {
            var command = $"{"CD " + txtDockerFileLocation.Text} && {DockerImage.CreateImageFromDockerFile(txtImageName.Text, "1.0")}";
            Execute(command); 
        }
        private void BtnRemoveImage_Click(object sender, EventArgs e)
        {
            var command = DockerImage.RemoveImage(ucImages2.GetSelectedKey());
            Execute(command);
        }

        private void BtnRemoveAllImages_Click(object sender, EventArgs e)
        {
            if (Helper.Confirm())
            {

            }
          
        }
        private void BtnContainerCreate_Click(object sender, EventArgs e)
        {
           var command = DockerContainer.RunImage(ucImageContainer.GetSelectedKey(), txtContainerName.Text,
                txtInsidePort.Value.ToInt(), txtOutSidePort.Value.ToInt(), new DockerRunOptions(true));
            Execute(command);
        }

       
    }
}
