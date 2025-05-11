using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scriptsupport.models
{
    public class Ticket
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string subject { get; set; }
        public int priority_id { get; set; }
        public int status_id { get; set; }
        public int rating { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime? deleted_at { get; set; }

        public Priority priority { get; set; }
        public Status status { get; set; }

        public User user { get; set; }
        public User assigned_to { get; set; }
        public List<Message> messages { get; set; }

    }
}
