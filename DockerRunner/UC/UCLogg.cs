using System.Windows.Forms;

namespace DockerRunner.UC
{
    public partial class UCLogg : UserControl
    {

        delegate void SetMergerTextCallback(string text);
        public UCLogg()
        {
            InitializeComponent();
        }

        public void SetLastRunningCommand(string cmd)
        {
            txtLastRunCommand.Text = cmd;
        }

        private void BtnClear_Click(object sender, System.EventArgs e)
        {
            if (Helper.Confirm())
                txtLogger.Text = string.Empty;
        } 

        public void Logg(string log)
        {
            if (this.txtLogger.InvokeRequired)
            {
                SetMergerTextCallback d = new SetMergerTextCallback(Logg);
                this.Invoke(d, new object[] { log });
            }
            else
            {
                this.txtLogger.Text = log;
            }
        }
    }
}
