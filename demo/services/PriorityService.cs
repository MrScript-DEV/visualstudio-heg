using scriptsupport.api;
using scriptsupport.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace scriptsupport.services
{
    class PriorityService
    {
        private readonly ApiService _api = new ApiService();

        public Task<ApiResponse<List<Priority>>> GetAllPriorities()
            => _api.SendRequestAsync<List<Priority>>("priorities", HttpMethod.Get, null, true);
    }
}
