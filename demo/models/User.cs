using scriptsupport.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scriptsupport
{
    public class User
    {
        public int? id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }

        public List<string> roles { get; set; }

        public int total_tickets { get; set; }

        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public List<Ticket> tickets { get; set; }

        public bool IsAdmin => roles != null && roles.Any(r => r.Equals("Admin", StringComparison.OrdinalIgnoreCase));


        public bool IsSupport => roles != null && roles.Any(r => r.Equals("Support", StringComparison.OrdinalIgnoreCase));
    }
}
