using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToBeLifeBetter.Service.Entity;

namespace ToBeLifeBetter.Service.EntityConfig
{
    public class CityConfig:EntityTypeConfiguration<CityEntity>
    {
        public CityConfig() 
        {
            ToTable("T_Cities");
            Property(m => m.Name).IsRequired().HasMaxLength(20);
        }
    }
}
