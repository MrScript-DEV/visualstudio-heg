using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scriptsupport.models
{
    public class Message
    {
        public int id { get; set; }
        public string content { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public User user { get; set; }
    }
}
