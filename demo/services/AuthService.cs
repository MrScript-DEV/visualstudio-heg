using Newtonsoft.Json;
using scriptsupport.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace scriptsupport.services
{
    class AuthService
    {
        private readonly ApiService _api = new ApiService();

        public async Task<(bool Success, string Message)> Login(string email, string password)
        {
            var credentials = new { email, password };

            try
            {
                var response = await _api.SendRequestAsync<LoginData>("login", HttpMethod.Post, credentials);

                if (response.success && response.data != null && !string.IsNullOrEmpty(response.data.token))
                {
                    ApiConfig.Token = response.data.token;
                    return (true, response.message ?? "Connexion réussie.");
                }

                return (false, response.message ?? "Token manquant.");
            }
            catch (System.Exception ex)
            {
                return (false, "Erreur : " + ex.Message);
            }
        }

        public async Task<(bool Success, string Message)> Logout()
        {
            try
            {
                var response = await _api.SendRequestAsync<object>("logout", HttpMethod.Post, null, true);
                ApiConfig.Token = null;

                return (response.success, response.message ?? "Déconnexion réussie.");
            }
            catch (System.Exception ex)
            {
                return (false, "Erreur lors de la déconnexion : " + ex.Message);
            }
        }

        public class LoginData
        {
            public string token { get; set; }
            public User user { get; set; }
        }


    }
}
