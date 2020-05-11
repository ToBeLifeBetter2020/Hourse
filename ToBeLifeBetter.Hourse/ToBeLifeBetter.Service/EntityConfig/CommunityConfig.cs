using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToBeLifeBetter.Service.Entity;

namespace ToBeLifeBetter.Service.EntityConfig
{
    public class CommunityConfig:EntityTypeConfiguration<CommunityEntity>
    {
 
        public CommunityConfig() 
        {
            ToTable("T_Communities");
            //Community必须有Region，一个Region有很多的Community，他们使用RegionId做外键
            this.HasRequired(m => m.Region).WithMany().HasForeignKey(m => m.RegionId).WillCascadeOnDelete(false);
            Property(m => m.Location).HasMaxLength(1024).IsRequired();
            Property(m => m.Name).HasMaxLength(20).IsRequired();
        }
    }
}
