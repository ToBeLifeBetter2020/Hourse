using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToBeLifeBetter.Service.Entity;
using System.Data.Entity.ModelConfiguration;

namespace ToBeLifeBetter.Service.EntityConfig
{
    
    public class AdminLogConfig: EntityTypeConfiguration<AdminLogEntity>
    {
        public AdminLogConfig() 
        {
            this.ToTable("T_AdminLogs");//配置表名

            //一个用户有多个日志，每个日志必定对应一个用户（用户和日志是一对多）
            this.HasRequired(m => m.AdminUser).WithMany().HasForeignKey(m=>m.AdminUserId).WillCascadeOnDelete(false);//取消级联删除
            this.Property(m => m.Message).IsRequired();
        }
    }
}
