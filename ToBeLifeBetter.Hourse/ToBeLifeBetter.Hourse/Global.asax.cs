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
using ToBeLifeBetter.Hourse.JsonFilter;
using ToBeLifeBetter.Service;

namespace ToBeLifeBetter.Hourse
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           GlobalFilters.Filters.Add(new JsonActionFilter());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            LoadAutofac();
        }

        protected void LoadAutofac()
        {
            var bulider = new ContainerBuilder();

            //������ע��
            bulider.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();
            //��ȡ��ҪAutofac����ĳ���
            Assembly[] assemblies = new Assembly[] {Assembly.Load("ToBeLifeBetter.Service") };
            bulider.RegisterAssemblyTypes(assemblies)
            .Where(type => !type.IsAbstract)
            .AsImplementedInterfaces().PropertiesAutowired();

            IContainer container =  bulider.Build();


            //ϵͳ��������
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }

    }
}
