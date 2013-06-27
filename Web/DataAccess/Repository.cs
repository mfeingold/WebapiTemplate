using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Web.Models;

namespace Web.DataAccess
{
    public class Repository : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ApplicationPermission> ApplicationPermissions { get; set; }
        public DbSet<Application> Applications { get; set; }
    }
}