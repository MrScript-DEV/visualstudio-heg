using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scriptsupport
{
    public static class ApiConfig
    {
        public static readonly string BaseUrl = "http://127.0.0.1:8000/api/";
        public static string Token { get; set; } = string.Empty;
        public static bool IsAuthenticated => !string.IsNullOrEmpty(Token);
    }
}
