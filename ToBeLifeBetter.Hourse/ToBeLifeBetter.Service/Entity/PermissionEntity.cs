using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToBeLifeBetter.Service.Entity
{
    /// <summary>
    /// 权限项
    /// </summary>
   public class PermissionEntity:BaseEntity
    {
        public string Description { get; set; }

        public string Name { get; set; }


    }
}
