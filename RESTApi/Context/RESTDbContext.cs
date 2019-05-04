using RESTApi.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RESTApi.Context
{
    public class RESTDbContext:DbContext
    {
        public RESTDbContext():base("RESTDbContext") {
            Database.SetInitializer<RESTDbContext>(new DropCreateDatabaseIfModelChanges<RESTDbContext>());
        }
        public DbSet<User> User { get; set; }
        
    }
}