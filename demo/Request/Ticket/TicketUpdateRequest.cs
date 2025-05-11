using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scriptsupport.Request.Ticket
{
    class TicketUpdateRequest
    {
        public string subject { get; set; }
        public int priority_id { get; set; }
        public int status_id { get; set; }
        public int assigned_to_id { get; set; }
    }
}
