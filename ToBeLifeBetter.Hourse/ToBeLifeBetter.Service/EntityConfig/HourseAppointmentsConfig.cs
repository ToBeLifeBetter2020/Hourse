using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToBeLifeBetter.Service.Entity;

namespace ToBeLifeBetter.Service.EntityConfig
{
    public class HouseAppointmentsConfig : EntityTypeConfiguration<HouseAppointmentEntity>
    {
        public HouseAppointmentsConfig() 
        {
            ToTable("T_HouseAppointments");
            //
            HasRequired(h => h.User).WithMany().HasForeignKey(h => h.UserId).WillCascadeOnDelete(false);

            HasRequired(h => h.House).WithMany().HasForeignKey(h => h.HouseId).WillCascadeOnDelete(false);

            HasOptional(h => h.FollowAdminUser).WithMany().HasForeignKey(h => h.FollowAdminUserId).WillCascadeOnDelete(false);

            Property(h => h.Name).IsRequired().HasMaxLength(20);
            Property(h => h.PhoneNumber).IsRequired().HasMaxLength(20).IsUnicode(false);
            Property(h => h.Status).IsRequired().HasMaxLength(20);
        }
    }
}
