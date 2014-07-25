using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebTest6.Models
{
    public class User
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int NoCommentsPosted { get; set; }
        public DateTime? joined { get; set; }
    }
    public class UserDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}