using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTest6.Models
{
    public class Message
    {
        public DateTime? posted { get; set; }
        public string user { get; set; }
        public string theMessage { get; set; }
        public int count { get; set; }
    }
}