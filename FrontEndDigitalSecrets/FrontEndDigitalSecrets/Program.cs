using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEndDigitalSecrets.Controllers;
using FrontEndDigitalSecrets.Forms;

namespace FrontEndDigitalSecrets
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SecretController secretController = new SecretController(new SecretBox(), new UploadController(new UploadSecretView(), new SecretService()));
            secretController.secretView.ShowDialog();
        }
    }
}

// Application.Run(new SecretController(new SecretBox (), new UploadController(new UploadSecretView(), new SecretService())));;
           //}