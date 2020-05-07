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
    public class RegionsEntity: BaseEntity
    {

        public string Name { get; set; }

        public int CityId { get; set; }

        //一个区域对应一个城市
        public virtual CitiesEntity City { get; set; }
    }
}
