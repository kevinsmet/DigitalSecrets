using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrontEndDigitalSecrets.Forms;

namespace FrontEndDigitalSecrets.Controllers {
    public interface ISecretService
    {
        void UploadSecret(string Description, string FirstName, string LastName);
    }
    public class SecretService : ISecretService{
        public void UploadSecret(string Description, string Firstname, string Lastname)
        {
            
            // implement reference to REST service 
        }   
    }
}
