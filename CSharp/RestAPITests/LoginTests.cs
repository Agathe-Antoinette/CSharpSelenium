using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestAPITests.Models;
using System.Net;
using System.Reflection;

namespace RestAPITests
{
    [TestClass]
    public class LoginTests
    {
        private const string Uri = "/api/token";

        [TestMethod]

        public void LoginExistingUserShouldProcessCorrectly()
        {
            var dataReader = new DataReader<LoginUser>();
            var loginUser = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            var service = new Service();
            var response = service.GetToken(Uri, loginUser).Result;
            string result = response.Content.ReadAsStringAsync().Result;

            Assert.IsTrue(response.IsSuccessStatusCode);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreNotEqual(string.Empty, result);
        }       

        // TODO : Negative Login Tests

    }
}
