using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToBeLifeBetter.Service.Entity
{
    /// <summary>
    /// 房屋配置表
    /// </summary>
    public class AttachmentEntity : BaseEntity
    {
        public string Name { get; set; }
        public string IconName { get; set; }

        /// <summary>
        /// 房屋和配置多对多关系
        /// </summary>
        public virtual ICollection<HouseEntity> Houses { get; set; } = new List<HouseEntity>();
    }
}
