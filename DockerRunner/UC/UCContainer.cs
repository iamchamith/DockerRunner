using System;
using System.Text;
using System.Windows.Forms;
using DockerRunner.Stages;
using model = DockerRunner.Model;
namespace DockerRunner.UC
{
    public partial class UCContainer : UserControl
    {
        Form1 _parent;
        int countDown = 2;
        const string refreshButtonName = "REFRESH";
        public UCContainer()
        {
            InitializeComponent();
        }
        public UCContainer SetParent(Form1 parent)
        {
            _parent = parent;
            return this;
        }
        private void BtnReloadContainers_Click(object sender, EventArgs e)
        {
            if (_parent == null)
                return;
            btnReloadContainers.Text = "WAITING...";
            LoadContainers();
        }
        void LoadContainers()
        {
            _parent.outputRead = new StringBuilder();
            var command = DockerContainer.GetContainerList(chkAllImages.Checked);
            _parent.ExecuteRead(command);
            timer1.Start();
        }
        void LoadInput()
        {
            var lst = DockerContainer.FilterContainers(_parent.outputRead.ToString());
            cmbContainers.DataSource = lst;
            cmbContainers.DisplayMember = nameof(model.Container.Value);
            cmbContainers.ValueMember = nameof(model.Container.Key);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            countDown--;
            if (countDown == 0)
            {
                LoadInput();
                countDown = 2;
                timer1.Stop();
                btnReloadContainers.Text = refreshButtonName;
                return;
            }
        }
        public string GetSelectedKey()
        {
            return cmbContainers.SelectedValue.ToString();
        }
    }
}
