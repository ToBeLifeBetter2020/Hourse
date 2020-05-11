using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToBeLifeBetter.Service.Entity
{
    public class AdminLogEntity : BaseEntity
    {
        /// <summary>
        /// 操作消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 操作用户
        /// </summary>
        public long AdminUserId { get; set; }
        public virtual UserEntity AdminUser { get; set; }
    }
}
