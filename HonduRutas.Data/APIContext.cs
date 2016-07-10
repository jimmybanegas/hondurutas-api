using HonduRutas.Data.DatabaseMapping;
using HonduRutas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HonduRutas.Data
{
    public sealed class APIContext : DbContext
    {
        public APIContext() : base("ExploraHNDatabase")
        {
            Database.SetInitializer<APIContext>(null);
        }
        public IDbSet<Route> Tests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new RouteEntityTypeConfiguration());
        }
    }
}
