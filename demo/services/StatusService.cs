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
    class StatusService
    {
        private readonly ApiService _api = new ApiService();

        public Task<ApiResponse<List<Status>>> GetAllStatuses()
            => _api.SendRequestAsync<List<Status>>("statuses", HttpMethod.Get, null, true);
    }
}
