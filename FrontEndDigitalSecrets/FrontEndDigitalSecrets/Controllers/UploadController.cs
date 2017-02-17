using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrontEndDigitalSecrets.Forms;

namespace FrontEndDigitalSecrets.Controllers {
   public class UploadController {
        internal IUploadView uploadView { get; }
        private ISecretService secretService;

        public UploadController(IUploadView uploadView, ISecretService secretService)
        {
            this.uploadView = uploadView;
            this.secretService = secretService;

            this.uploadView.SetController(this);
        }
        public void UploadSecret(string Description, string FirstName, string LastName)
        {
            secretService.UploadSecret(Description, FirstName, LastName);
            uploadView.Close();
        }
    }
}
