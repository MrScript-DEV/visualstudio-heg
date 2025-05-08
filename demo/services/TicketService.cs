using scriptsupport.api;
using scriptsupport.models;
using scriptsupport.Request.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace scriptsupport.services
{
    class TicketService
    {
        private readonly ApiService _api = new ApiService();

        public Task<ApiResponse<List<Ticket>>> GetAllTickets() 
            => _api.SendRequestAsync<List<Ticket>>("tickets", HttpMethod.Get, null, true);
    }
}
