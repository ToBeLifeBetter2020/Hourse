using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToBeLifeBetter.Service.Entity;

namespace ToBeLifeBetter.Service.EntityConfig
{
    public class AttachmentsConfig : EntityTypeConfiguration<AttachmentEntity>
    {

        public AttachmentsConfig()
        {
            ToTable("T_Attachments");

            //房屋和房屋配置 多对多关系
            HasMany(m => m.Houses).WithMany(m=>m.Attachments).Map(m=>m.ToTable("T_HouseAttachments").MapLeftKey("AttachmentId").MapRightKey("HouseId"));


            Property(m => m.IconName).IsRequired().HasMaxLength(50).IsUnicode(false);
            Property(m => m.Name).IsRequired().HasMaxLength(50);
        }
    }
}
