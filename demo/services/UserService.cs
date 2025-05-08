using scriptsupport.api;
using scriptsupport.Request.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace scriptsupport.services
{
    public class UserService
    {
        private readonly ApiService _api = new ApiService();

        public Task<ApiResponse<List<User>>> GetAllUsers(string role = null)
        {
            string endpoint = "users";

            if (!string.IsNullOrEmpty(role))
            {
                endpoint += $"?role={Uri.EscapeDataString(role)}";
            }

            return _api.SendRequestAsync<List<User>>(endpoint, HttpMethod.Get, null, true);
        }

        public Task<ApiResponse<User>> GetUserById(int id)
            => _api.SendRequestAsync<User>($"users/{id}", HttpMethod.Get, null, true);

        public Task<ApiResponse<User>> CreateUser(UserCreateRequest user)
            => _api.SendRequestAsync<User>("users", HttpMethod.Post, user, true);

        public Task<ApiResponse<User>> UpdateUser(int id, UserUpdateRequest user)
            => _api.SendRequestAsync<User>($"users/{id}", HttpMethod.Put, user, true);

        public Task<ApiResponse<object>> SoftDeleteUser(int id)
            => _api.SendRequestAsync<object>($"users/{id}/soft", HttpMethod.Delete, null, true);

        public Task<ApiResponse<object>> DestroyUser(int id)
            => _api.SendRequestAsync<object>($"users/{id}", HttpMethod.Delete, null, true);
    }
}
