using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToBeLifeBetter.Service.Entity
{
    public class BaseEntity
    {
        public long Id { get; set; }

        public bool IsDeleted  { get; set; }

        public DateTime CreateDataTime { get; set; }

    }
}
