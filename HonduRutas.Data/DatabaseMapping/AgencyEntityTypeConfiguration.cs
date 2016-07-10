using HonduRutas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HonduRutas.Data.DatabaseMapping
{
    public class AgencyEntityTypeConfiguration : EntityTypeConfiguration<Agency>
    {
        public AgencyEntityTypeConfiguration()
        {
            //Table
            ToTable("Agency", "Explora");

            //Primary Key
            HasKey(u => u.AgencyId);

            //Columns
            Property(u => u.AgencyId).HasColumnName("AgencyId").HasMaxLength(50).IsRequired();
            Property(u => u.AgencyName).HasColumnName("AgencyName").HasMaxLength(50);
            Property(u => u.AgencyUrl).HasColumnName("AgencyUrl").HasMaxLength(1024);
            Property(u => u.AgencyPhone).HasColumnName("AgencyPhone").HasMaxLength(15);
            Property(u => u.AgencyLang).HasColumnName("AgencyLang").HasMaxLength(2);
            Property(u => u.AgencyFareUrl).HasColumnName("AgencyFareUrl").HasMaxLength(1024);
        }
    }
}
