using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToBeLifeBetter.Service.Entity
{
    public class AdminUserEntity : BaseEntity
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public int CityId { get; set; }
        public virtual CitiesEntity City{get;set;}
        public int LoginErrorTimes { get; set; }
        public int LastLoginErrorDataTimes { get; set; }
    }
}
