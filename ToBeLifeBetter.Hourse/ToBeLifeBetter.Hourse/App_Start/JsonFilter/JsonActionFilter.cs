using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToBeLifeBetter.Hourse;

namespace ToBeLifeBetter.Hourse.JsonFilter
{
    /// <summary>
    ///  替换Asp.Net Mvc的Json的时间处理部分
    /// </summary>
    public class JsonActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //替换JsonResult为我们的JsonResult
            if (filterContext.Result is JsonResult && !(filterContext.Result is JsonFormat))
            {
                JsonResult jsonResult = (JsonResult)filterContext.Result;
                JsonFormat jsonNetResult = new JsonFormat();
                jsonNetResult.ContentEncoding = jsonResult.ContentEncoding;
                jsonNetResult.ContentType = jsonResult.ContentType;
                jsonNetResult.Data = jsonResult.Data;
                jsonNetResult.JsonRequestBehavior = jsonResult.JsonRequestBehavior;
                jsonNetResult.MaxJsonLength = jsonResult.MaxJsonLength;
                jsonNetResult.RecursionLimit = jsonResult.RecursionLimit;
                filterContext.Result = jsonNetResult;
            }
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {}

    }
}