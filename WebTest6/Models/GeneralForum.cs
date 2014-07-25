using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebTest6.Models
{
    public class GeneralForum
    {
        public string ID { get; set; }
        public Message theMessage { get; set; }
    }
    public class ForumDBContext : DbContext
    {
        public DbSet<GeneralForum> Messages { get; set; }
    }
}