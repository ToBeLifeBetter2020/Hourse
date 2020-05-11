using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToBeLifeBetter.Service.Entity
{
    public class UserEntity : BaseEntity
    {
        public string PhoneNumber { get; set; }

        public string PasswordHash { get; set; }

        public string PasswordSalt { get; set; }

        /// <summary>
        /// 登录错误次数 为了锁定
        /// </summary>
        public string LoginErrorTimes { get; set; }

        /// <summary>
        /// 最后一次错误登录时间  锁定多久时间
        /// </summary>
        public DateTime? LoginErrorDateTime { get; set; }

        public long? CityId { get; set; }

        public virtual CityEntity City { get; set; }
    }
}
