using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToBeLifeBetter.Service.Entity
{
    /// <summary>
    /// 管理员用户实体
    /// </summary>
    public class AdminUserEntity : BaseEntity
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public long? CityId { get; set; }
        public virtual CityEntity City { get; set; }
        public int LoginErrorTimes { get; set; }
        public DateTime? LastLoginErrorDataTimes { get; set; }

        /// <summary>
        /// 用户和角色是多对多关系
        /// </summary>
        public virtual ICollection<RoleEntity> Roles { get; set; } = new List<RoleEntity>();
    }
}
