using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Net.Http.Headers;
using RestAPITests.Models;
using System.Reflection;
using Newtonsoft.Json;
using System.Net;

namespace RestAPITests
{
    [TestClass]
    public class RegistrationTests
    {
        private const string Uri = "/api/account/register";

        [TestMethod]
        public void RegisterNewUserShouldProccessCorrectly()
        {
            var dataReader = new DataReader<RegistrationUser>();
            var registrationUser = dataReader.GetData(MethodBase.GetCurrentMethod().Name);
            registrationUser.Email = string.Format(registrationUser.Email,Guid.NewGuid());

            var service = new Service();
            var response = service.PostAsync(Uri, registrationUser).Result;
            string result = response.Content.ReadAsStringAsync().Result;

            Assert.IsTrue(response.IsSuccessStatusCode);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual(string.Empty, result);
        }

        // TODO: Negative Registration Tests


    }
}
