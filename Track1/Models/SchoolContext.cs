using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Track1.Models.Seed;

namespace Track1.Models
{
    public class SchoolContext: DbContext
    {
        public SchoolContext() : base("name=IncentiveTracker")
        {
            //Database.SetInitializer(new SchoolDBInitializer());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolContext, Migrations.Configuration>("IncentiveTracker"));
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Standard> Standard { get; set; }
    }
}