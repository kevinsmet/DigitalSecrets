using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrontEndDigitalSecrets.Forms;
using RestSharp;

namespace FrontEndDigitalSecrets.Controllers {
    public interface ISecretService
    {
        void UploadSecret(string Description, string FirstName, string LastName);
    }
    public class SecretService : ISecretService{
            
        public void UploadSecret(string Description, string Firstname, string Lastname)
        {
            var client = new RestClient("http://localhost:8080");
            var request = new RestRequest("Secret", Method.POST);
       //     request.AddParameter(Description, Firstname,Lastname);
            IRestResponse response = client.Execute(request);
            var content = response.Content;

        }   
    }
}
