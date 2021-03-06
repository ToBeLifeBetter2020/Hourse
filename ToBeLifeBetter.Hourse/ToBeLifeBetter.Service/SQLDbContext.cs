﻿using log4net;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ToBeLifeBetter.LogEasy;
using ToBeLifeBetter.Service.Entity;

namespace ToBeLifeBetter.Service
{
    public class SQLDbContext : DbContext
    {
        //ILog ILogger,
        //private static ILog log = ToBeLifeBetter.LogEasy.;//LogManager.GetLogger(typeof(SQLDbContext));


        public SQLDbContext():base("name=conStr")
            //name=conn1表示使用连接字符串中名字为conn1的去连接数据库
        {
            Database.SetInitializer<SQLDbContext>(null);
            this.Database.Log = (sql) => {
                //LogHelper.Info("EF执行SQL：{0}");
                ToBeLifeBetter.LogEasy.LogHelper.Debug("EF执行SQL：{0}",sql);
            };        
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());           
        }
        public DbSet<AdminUserEntity> AdminUsers { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CityEntity> Cities { get; set; }
        public DbSet<CommunityEntity> Communities { get; set; }
        public DbSet<PermissionEntity> Permissions { get; set; }
        public DbSet<RegionEntity> Regions { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<SettingEntity> Settings { get; set; }
        public DbSet<AttachmentEntity> Attachments { get; set; }
        public DbSet<HouseEntity> Houses { get; set; }
        public DbSet<HouseAppointmentEntity> HouseAppointments { get; set; }
        public DbSet<IdNameEntity> IdNames { get; set; }
        public DbSet<HousePictureEntity> HousePics { get; set; }
        public DbSet<AdminLogEntity> AdminUserLogs { get; set; }
    }

}
