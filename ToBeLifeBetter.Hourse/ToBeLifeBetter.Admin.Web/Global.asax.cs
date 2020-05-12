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
            LogEasy.LogHelper.Info("��̨��վ����");
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
            type1���ͱ����Ƿ����ָ��type2���͵Ķ����ж�IServiceAutoFac�ӿ��Ƿ�typeʵ��
            �����޹��౻autofacע��
            */

            var container = builder.Build();
            //ע��ϵͳ����DependencyResolver��������MVC��ܴ���Controllerʱ
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));


        }
    }
}
