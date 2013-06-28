using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Web.Models;

namespace Web.DataAccess
{
    public class Repository : DbContext, IRepository
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ApplicationPermission> ApplicationPermissions { get; set; }
        public DbSet<Application> Applications { get; set; }

        public IDbSet<T> Entity<T>() where T : class {
            return Set<T>();
        }
    }

    public interface IRepository : IDisposable {
        IDbSet<T> Entity<T>() where T : class;
    } 
}