using HonduRutas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HonduRutas.Data.DatabaseMapping
{
    public class RouteEntityTypeConfiguration : EntityTypeConfiguration<Route>
    {
        public RouteEntityTypeConfiguration()
        {
            //Table
            ToTable("Route", "Explora");

            //Primary Key
            HasKey(u => u.RouteId);

            //Columns
            Property(u => u.RouteId).HasColumnName("RouteId").IsRequired();
            Property(u => u.AgencyId).HasColumnName("AgencyId").IsRequired().HasMaxLength(100);
            Property(u => u.RouteShortName).HasColumnName("RouteShortName").HasMaxLength(50);
            Property(u => u.RouteLongName).HasColumnName("RouteLongName").HasMaxLength(250);
            Property(u => u.RouteDesc).HasColumnName("RouteDesc").HasMaxLength(1024);
            Property(u => u.RouteType).HasColumnName("RouteType");
            Property(u => u.RouteUrl).HasColumnName("RouteUrl ").HasMaxLength(1024);
            Property(u => u.RouteColor).HasColumnName("RouteColor").HasMaxLength(20);
        }
    }
}