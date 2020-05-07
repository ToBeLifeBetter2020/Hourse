using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToBeLifeBetter.Service.Entity
{
    public class AdminLogsEntity:BaseEntity
    {
        public string Msg { get; set; }
        public long UserId { get; set; }
        public virtual UsersEntity User { get; set; }

    }
}
