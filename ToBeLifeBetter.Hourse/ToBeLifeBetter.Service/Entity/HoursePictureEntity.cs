using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToBeLifeBetter.Service.Entity
{
   public class HoursePictureEntity:BaseEntity
    {
        /// <summary>
        /// 图片网址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 缩略图地址
        /// </summary>
        public string ThumbUrl { get; set; }


    }
}
