using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToBeLifeBetter.Admin.Web.App_Start.Filter
{
    /// <summary>
    /// 未处理异常
    /// </summary>
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            LogEasy.LogHelper.Error("出现了未处理异常"+filterContext.Exception);
        }
    }
}