﻿using RestSharp;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace casdoor_dotnet_winform_example
{
    internal class CasdoorApi
    {
        private static readonly string _requestTokenUrl = "/api/login/oauth/access_token";
        private static readonly string _getUserInfoUrl = "/api/userinfo";

        private readonly RestClient _client;

        public CasdoorApi(string baseAddress) => _client = new RestClient(baseAddress);

        public async Task<string?> RequestToken(string clientId, string clientSecret, string code)
        {
            var body = new 
            { 
                grant_type = "authorization_code", 
                client_id = clientId, 
                client_secret = clientSecret, 
                code
            };

            var req = new RestRequest(_requestTokenUrl).AddJsonBody(body);
            var token = await _client.PostAsync<TokenDto>(req);

            return token?.AccessToken;
        }

        public async Task<UserDto?> GetUserInfo(string token)
        {
            var req = new RestRequest(_getUserInfoUrl).AddQueryParameter("accessToken", token);

            return await _client.GetAsync<UserDto>(req);
        }

        private class TokenDto
        {
            [JsonPropertyName("access_token")]
            public string? AccessToken { get; set; }
        }
    }

    internal record UserDto(
        string Name,
        string Email,
        string Phone
    );
}
