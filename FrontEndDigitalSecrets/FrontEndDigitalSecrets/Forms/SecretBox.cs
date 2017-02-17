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

namespace FrontEndDigitalSecrets {
    public interface ISecretBoxView
    {
        void SetController(SecretController secretController);
        DialogResult ShowDialog();
    }

    public partial class SecretBox : Form, ISecretBoxView
    {
        private SecretController secretController;
        public SecretBox() {
            InitializeComponent();
        }

        private void AddASecret_Click(object sender, EventArgs e)
        {
            secretController.ShowAddSecretForm();
        }

        private void ViewSecretOfTheDay_Click(object sender, EventArgs e) {
            
        }

        public void SetController(SecretController secretController)
        {
            this.secretController = secretController;
        }

    }
}
