using scriptsupport.api;
using scriptsupport.models;
using scriptsupport.Request.Message;
using scriptsupport.Request.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace scriptsupport.services
{
    class MessageService
    {
        private readonly ApiService _api = new ApiService();

        public Task<ApiResponse<Message>> CreateMessage(MessageCreateRequest message)
    => _api.SendRequestAsync<Message>("messages", HttpMethod.Post, message, true);
    }
}
