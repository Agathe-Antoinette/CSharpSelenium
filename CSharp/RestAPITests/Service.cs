using RestAPITests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RestAPITests
{
    public class Service
    {
        private static string baseUri = "http://spots.kostov.net";

        public async Task<HttpResponseMessage> GetAsync(string uri)
        {
            var client = GetClient();
            return await client.GetAsync(uri);
        }

        public async Task<HttpResponseMessage> PostAsync(string uri, object data)
        {
            var client = GetClient();
            return await client.PostAsJsonAsync(uri, data);
        }

        public async Task<HttpResponseMessage> PutAsync(string uri, string data)
        {
            var client = GetClient();
            return await client.PutAsJsonAsync(uri, data);
        }

        public async Task<HttpResponseMessage> DeleteAsync(string uri)
        {
            var client = GetClient();
            return await client.DeleteAsync(uri);
        }

        public static HttpClient GetClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseUri);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        public async Task<HttpResponseMessage> GetToken(string uri, LoginUser user)
        {
            var client = GetClient();

            var form = new FormUrlEncodedContent(new []
            {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("Username", user.Username),
                new KeyValuePair<string, string>("Password", user.Password)
            });

            return await client.PostAsync(uri, form);
        }
        
    }
}
