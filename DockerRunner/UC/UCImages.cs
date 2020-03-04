using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DockerRunner.Model;
using DockerRunner.Stages;

namespace DockerRunner.UC
{
    public partial class UCImages : UserControl
    {
        Form1 _parent;
        int countDown = 2;
        const string refreshButtonName = "REFRESH";
        List<UCImages> _ucImages = null;
        List<Image> _images { get; set; }
        public UCImages()
        {
            InitializeComponent();
        }
        public UCImages SetParent(Form1 parent,List<UCImages> ucImages=null)
        {
            _parent = parent;
            _ucImages = ucImages;
            return this;
        }
        private void BtnReloadImages_Click(object sender, EventArgs e)
        {
            if (_parent == null)
                return;
            btnReloadImages.Text = "WAITING...";
            LoadImages();
        }

        void LoadImages()
        {
            _parent.outputRead = new StringBuilder();
            var command = DockerImage.GetImageList();
            _parent.ExecuteRead(command);
            timer1.Start();
        }
        void LoadInput()
        {
            _images = DockerImage.FilterImages(_parent.outputRead.ToString());
            cmbImages.DataSource = _images;
            cmbImages.DisplayMember = nameof(Image.Value);
            cmbImages.ValueMember = nameof(Image.Key);
        }
        public void LoadInput(List<Image> data)
        { 
            cmbImages.DataSource = data;
            cmbImages.DisplayMember = nameof(Image.Value);
            cmbImages.ValueMember = nameof(Image.Key);
        }
        void TrigerOnOthers() {
            foreach (var item in _ucImages)           
                item.LoadInput(_images);          
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            countDown--;
            if (countDown == 0)
            {
                LoadInput();
                TrigerOnOthers();
                countDown = 2;
                timer1.Stop();
                btnReloadImages.Text = refreshButtonName;
                return;
            }
        }
        public string GetSelectedKey() {

            return cmbImages.SelectedValue.ToString();
        }
    }
}
