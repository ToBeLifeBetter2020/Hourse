using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToBeLifeBetter.Service.Entity
{
    public class HouseAppointmentEntity : BaseEntity
    {
     
        
         
         
        
       
    
       

        public long? UserId { get; set; }
        public virtual UserEntity User { get; set; }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime VisitDateTime { get; set; }

        public long HouseId { get; set; }
        public virtual HouseEntity House { get; set; }

        /// <summary>
        /// 处理状态
        /// </summary>
        public string Status { get; set; }
        //public virtual IdNameEntity Status { get; set; }

        /// <summary>
        /// 跟踪人
        /// </summary>
        public long? FollowAdminUserId { get; set; }
        public virtual AdminUserEntity FollowAdminUser { get; set; }

        /// <summary>
        /// 跟踪时间
        /// </summary>
        public DateTime? FollowDateTime { get; set; }

    }
}
