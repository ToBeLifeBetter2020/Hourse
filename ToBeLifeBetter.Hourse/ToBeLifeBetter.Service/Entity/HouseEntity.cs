using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToBeLifeBetter.Service.Entity
{

    /// <summary>
    /// 房屋信息表
    /// </summary>
    public class HouseEntity : BaseEntity
    {
        /// <summary>
        /// 小区Id
        /// </summary>
        public long CommunityId { get; set; }
        public virtual CommunityEntity Community { get; set; }

        /// <summary>
        /// 指向T_IdName
        /// </summary>
        public long RoomTypeId { get; set; }
        public virtual IdNameEntity RoomType { get; set; }

        public string Address { get; set; }

        /// <summary>
        /// 月佣金
        /// </summary>
        public int MonthRent { get; set; }

        /// <summary>
        /// 状态Id 指向IdName
        /// </summary>
        public long StatusId { get; set; }
        public virtual IdNameEntity Status { get; set; }


        /// <summary>
        /// 面积
        /// </summary>
        public int Area { get; set; }

        /// <summary>
        /// 装修状态 指向IdName
        /// </summary>
        public long DecorateStatusId { get; set; }
        public virtual IdNameEntity DecorateStatus { get; set; }

        /// <summary>
        /// 总楼层数
        /// </summary>
        public int TotalFloorCount { get; set; }

        /// <summary>
        /// 楼层
        /// </summary>
        public int FloorIndex { get; set; }

        /// <summary>
        /// 房屋类型Id 指向T_IdName
        /// </summary>
        public long TypeId { get; set; }
        public virtual IdNameEntity Type { get; set; }

        /// <summary>
        /// 朝向
        /// </summary>
        public string Direction { get; set; }

        /// <summary>
        /// 可看房时间
        /// </summary>
        public DateTime LookableDateTime { get; set; }

        /// <summary>
        /// 可入住时间
        /// </summary>
        public DateTime CheckInDateTime { get; set; }

        /// <summary>
        /// 业主姓名
        /// </summary>
        public string OwenName { get; set; }

        /// <summary>
        /// 业主手机号
        /// </summary>
        public string OwenPhoneNumber { get; set; }


        /// <summary>
        /// 房子描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 房屋和房屋配置 是多对对关系
        /// </summary>
        public virtual ICollection<AttachmentEntity> Attachments { get; set; } = new List<AttachmentEntity>();

        /// <summary>
        /// 房屋和房屋图片是一对多关系
        /// </summary>
        public virtual ICollection<HousePictureEntity> HousePics { get; set; } = new List<HousePictureEntity>();

    }
}
