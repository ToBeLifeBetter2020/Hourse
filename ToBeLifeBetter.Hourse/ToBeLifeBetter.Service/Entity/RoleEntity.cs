using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToBeLifeBetter.Service.Entity
{
    /// <summary>
    /// 角色表
    /// </summary>
    public class RoleEntity : BaseEntity
    {
        public string Name { get; set; }


        //既可以一张表对应一个Entity，关系表也建立实体，也可以像这样直接让对象带属性，隐式的关系表，会自动创建关系表
        //一个角色对应多个权限
        public virtual ICollection<PermissionEntity> Permissions { get; set; } = new List<PermissionEntity>();

        /// <summary>
        /// 一个角色可对应多个用户
        /// </summary>
        public ICollection<AdminUserEntity> AdminUsers { get; set; } = new List<AdminUserEntity>();
    }
}
