using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ToBeLifeBetter.Hourse.Models
{
    public class MVCHelper
    {

        /// <summary>
        /// 数据验证错误结果信息
        /// </summary>
        /// <param name="modelState"></param>
        /// <returns></returns>
        public static string GetValidateMessage(ModelStateDictionary modelState) 
        {
            StringBuilder sb = new StringBuilder();
            foreach (var key in modelState.Keys)
            {
                if (modelState[key].Errors.Count <= 0) 
                {
                    continue;
                }
                sb.Append($"属性【{key}】错误=>{{");
                foreach (var error in modelState[key].Errors)
                {
                    sb.Append(error.ErrorMessage);
                }
                sb.Append($"}}");

            }
            return sb.ToString();

        }
    }
}