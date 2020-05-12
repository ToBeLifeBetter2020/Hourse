using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ToBeLifeBetter.Admin.Web.App_Start.Filter;

namespace ToBeLifeBetter.Admin.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            GlobalFilters.Filters.Add(new ExceptionFilter());
            AutoFacInit();
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            LogEasy.LogHelper.Info("后台网站启动");
        }

        private void AutoFacInit() 
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();

            Assembly[] assemblies = new Assembly[] { Assembly.Load("ToBeLifeBetter.Service") };
            builder.RegisterAssemblyTypes(assemblies)
                .Where(type => !type.IsAbstract&&typeof(IServiceAutoFac).IsAssignableFrom(type))
                .AsImplementedInterfaces().PropertiesAutowired();
            /*typeof(IServiceAutoFac).IsAssignableFrom(type))
            type1类型变量是否可以指向type2类型的对象：判断IServiceAutoFac接口是否被type实现
            避免无关类被autofac注册
            */

            var container = builder.Build();
            //注册系统级的DependencyResolver，这样当MVC框架创建Controller时
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));


        }
    }
}
