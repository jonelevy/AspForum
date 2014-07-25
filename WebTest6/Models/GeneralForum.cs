using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebTest6.Models
{


    public class GeneralForum
    {
        public enum messageCount
        {
            count = 0
        };

        public string ID { get; set; }
        public int number { get; set; }
        public string Text { get; set; }
        public string User { get; set; }
        public DateTime? Time_Posted { get; set; }
    }
    public class ForumDBContext : DbContext
    {
        public DbSet<GeneralForum> Messages { get; set; }
    }
}