using System.Net.Http;
using KeiraTheCaticorn.Models;
using Newtonsoft.Json;
using RestSharp;

namespace KeiraTheCaticorn.DataAccess
{
    public class ArtDAL
    {
        private readonly HttpClient _client;
        public ArtDAL(HttpClient client)
        {
            _client = client;
        }

        public static AccessToken GetToken()
        {
            string clientId = Secret.ClientId;
            string clientSecret = Secret.ClientSecret;

            RestClient client = new RestClient($"https://www.deviantart.com/oauth2/token?client_id={clientId}&client_secret={clientSecret}&grant_type=client_credentials")
            {
                Timeout = -1
            };

            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);

            AccessToken access = JsonConvert.DeserializeObject<AccessToken>(response.Content);

            return access;
        }

        public Rootobject GetGallery()
        {
            AccessToken token = GetToken();
            string username = Secret.Artist;

            var client = new RestClient($"https://www.deviantart.com/api/v1/oauth2/gallery/all?username={username}")
            {
                Timeout = -1
            };

            RestRequest request = new RestRequest(Method.GET);

            request.AddHeader("Authorization", $"{token.token_type} {token.access_token}");

            IRestResponse response = client.Execute(request);

            Rootobject ro = JsonConvert.DeserializeObject<Rootobject>(response.Content);

            return ro;
        }
    }
}
