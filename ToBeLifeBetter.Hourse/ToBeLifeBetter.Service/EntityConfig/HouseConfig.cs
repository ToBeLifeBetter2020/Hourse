using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToBeLifeBetter.Service.Entity;

namespace ToBeLifeBetter.Service.EntityConfig
{
    public class HouseConfig:EntityTypeConfiguration<HouseEntity>
    {

        public HouseConfig() 
        {
            ToTable("T_Houses");
            HasRequired(h => h.Community).WithMany().HasForeignKey(h => h.CommunityId).WillCascadeOnDelete(false);
            HasRequired(h => h.RoomType).WithMany().HasForeignKey(h => h.RoomTypeId).WillCascadeOnDelete(false);
            HasRequired(h => h.Status).WithMany().HasForeignKey(h => h.StatusId).WillCascadeOnDelete(false);
            HasRequired(h => h.DecorateStatus).WithMany().HasForeignKey(h => h.DecorateStatusId).WillCascadeOnDelete(false);
            HasRequired(h => h.Type).WithMany().HasForeignKey(h => h.TypeId).WillCascadeOnDelete(false);
            Property(h => h.Address).IsRequired().HasMaxLength(128);
            Property(h => h.Description).IsOptional();
            Property(h => h.Direction).IsRequired().HasMaxLength(20);
            Property(h => h.OwenName).IsRequired().HasMaxLength(20);
            Property(h => h.OwenPhoneNumber).IsRequired().HasMaxLength(20).IsUnicode(false);
        }
    }
}
