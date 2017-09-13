using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Net.Http.Headers;
using RestAPITests.Models;
using System.Reflection;
using Newtonsoft.Json;

namespace RestAPITests
{
    [TestClass]
    public class RegistrationTests
    {
        private HttpClient client = new HttpClient();

        [TestMethod]
        public void RegisterNewUserShouldProccessCorrectly()
        {
            var registerUri = "http://spots.kostov.net/api/account/register";
            this.SetupClient(registerUri);

            var dataReader = new DataReader<RegistrationUser>();
            var registrationUser = dataReader.GetData(MethodBase.GetCurrentMethod().Name);
            registrationUser.Email = string.Format(registrationUser.Email,Guid.NewGuid());
            var registrationUserJson = JsonConvert.SerializeObject(registrationUser);
            var response = this.client.PostAsJsonAsync(registerUri, registrationUserJson).Result;


        }

        private void SetupClient(string uri)
        {
            this.client.BaseAddress = new Uri(uri);
            this.client.DefaultRequestHeaders.Accept.Clear();
            this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
