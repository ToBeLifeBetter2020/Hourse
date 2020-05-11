using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToBeLifeBetter.Service.Entity
{
    public class HousePictureEntity : BaseEntity
    {
        /// <summary>
        /// 图片网址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 缩略图地址
        /// </summary>
        public string ThumbUrl { get; set; }
        /// <summary>
        /// 房屋图片和房屋是一对一
        /// </summary>
        public long HouseId { get; set; }
        public virtual HouseEntity House { get; set; }


    }
}
