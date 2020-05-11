using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToBeLifeBetter.Service.Entity
{
    /// <summary>
    /// 系统配置实体
    /// 一些相关配置的实体 ，该映射表替代配置文件
    /// </summary>
    public class SettingEntity : BaseEntity
    {

        public string Name { get; set; }

        public string Value { get; set; }



    }
}
