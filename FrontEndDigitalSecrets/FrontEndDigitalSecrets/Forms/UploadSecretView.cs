using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEndDigitalSecrets.Controllers;

namespace FrontEndDigitalSecrets.Forms {
    public interface IUploadView
    {
        void SetController(UploadController uploadController);
        void Close();
        void Clear();
        DialogResult ShowDialog();
    }
    public partial class UploadSecretView : Form, IUploadView
    {
        public UploadController uploadController;
        public UploadSecretView() {
            InitializeComponent();
        }

        public void SetController(UploadController uploadController)
        {
            this.uploadController = uploadController;
        }

        public void Clear()
        {
            txtDescription.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
        }


        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void UploadSecretView_Load(object sender, EventArgs e) {

        }

        private void Upload_Click_1(object sender, EventArgs e)
        {
            uploadController.UploadSecret(txtDescription.Text, txtFirstName.Text, txtLastName.Text);
            this.Close();
        }
    }
}
