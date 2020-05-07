using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToBeLifeBetter.Service.Entity
{
    public class HourseAppointmentsEntity : BaseEntity
    {
        public long UserId { get; set; }
        public virtual UsersEntity User { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime VisitDateTime { get; set; }

        public long HourseId { get; set; }
        public virtual HousesEntity House { get; set; }//

        /// <summary>
        /// 处理状态Id 指向IdName
        /// </summary>
        public long StatusId { get; set; }
        public virtual IdNames Status { get; set; }

        /// <summary>
        /// 跟踪人
        /// </summary>
        public long FollowAdminUserId { get; set; }
        public virtual AdminUserEntity AdminUser{get;set;}

        /// <summary>
        /// 跟踪时间
        /// </summary>
        public DateTime FollowDateTime { get; set; }

    }
}
