using System.Web;
using System.Web.Mvc;

namespace ToBeLifeBetter.Hourse
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
