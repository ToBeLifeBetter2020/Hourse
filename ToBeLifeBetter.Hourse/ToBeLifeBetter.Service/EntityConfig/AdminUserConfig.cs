using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToBeLifeBetter.Service.Entity;

namespace ToBeLifeBetter.Service.EntityConfig
{
    public class AdminUserConfig:EntityTypeConfiguration<AdminUserEntity>
    {
        public AdminUserConfig() 
        {
            this.ToTable("T_AdminUsers");

            //用户表和城市表是多对一关系（一个城市可能包含多个用户） 用户也可以不填城市
            this.HasOptional(m => m.City).WithMany().HasForeignKey(u => u.CityId)
                .WillCascadeOnDelete(false);

            //用户表和权限表 多对多关系（单纯）
            this.HasMany(m => m.Roles).WithMany().Map(m=>m.ToTable("T_T_AdminUserRoles").MapLeftKey("AdminUserId").MapRightKey("RoleId"));

            Property(m => m.Name).HasMaxLength(50).IsRequired();
            Property(m => m.Email).HasMaxLength(30).IsRequired().IsUnicode(false);//varchar(30)
            Property(e => e.PhoneNumber).HasMaxLength(20).IsRequired().IsUnicode(false);
            Property(e => e.PasswordSalt).HasMaxLength(20).IsRequired().IsUnicode(false);
            Property(e => e.PasswordHash).HasMaxLength(100).IsRequired().IsUnicode(false);
        }

    }
}
