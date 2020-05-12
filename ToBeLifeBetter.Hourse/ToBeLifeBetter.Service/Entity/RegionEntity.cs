using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToBeLifeBetter.Service.Entity
{
    /// <summary>
    /// 区域表
    /// </summary>
    public class RegionEntity : BaseEntity
    {

        public string Name { get; set; }

        public long CityId { get; set; }

        //一个区域对应一个城市
        public virtual CityEntity City { get; set; }
    }
}
