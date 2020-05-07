using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToBeLifeBetter.Service.Entity
{
    /// <summary>
    /// 小区
    /// </summary>
    public class CommunitiesEntity: BaseEntity
    {
        public string Name { get; set; }

        public long RegionId { get; set; }

        public virtual RegionsEntity Region { get; set; }

        public string Location { get; set; }

        public string Traffic { get; set; }

        public int BuiltYear { get; set; }


    }
}
