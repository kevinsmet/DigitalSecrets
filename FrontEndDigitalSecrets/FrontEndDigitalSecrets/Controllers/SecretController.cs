using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndDigitalSecrets.Controllers {
    public class SecretController {
        internal ISecretBoxView secretView { get; }
        internal UploadController uploadController { get; }

        public SecretController(ISecretBoxView secretBoxView, UploadController uploadController)
        {
            this.secretView = secretBoxView;
            this.uploadController = uploadController;
            secretBoxView.SetController(this);
        }


        public void ShowAddSecretForm()
        {
            uploadController.uploadView.ShowDialog();
        }

       
    }
}
