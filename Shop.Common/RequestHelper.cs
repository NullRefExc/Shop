using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Common
{
    public class RequestHelper
    {
        public static string String(string name)
        {
            string value = System.Web.HttpContext.Current.Request.QueryString[name];            
            if (value == null)
            {
                value = "";
            }
            return value;
        }


        public static int Int(string name)
        {
            int value = 0;
            int.TryParse(System.Web.HttpContext.Current.Request.QueryString[name], out value);
            return value;
        }

        public static bool Bool(string name)
        {
            bool value = false;
            if (string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.Form[name]))
            {
                bool.TryParse(System.Web.HttpContext.Current.Request.Params[name], out value);
            }
            else
            {
                bool.TryParse(System.Web.HttpContext.Current.Request.Form[name], out value);
            }
            return value;
        }

        public static double Double(string name)
        {
            double value = 0;
            if (string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.Form[name]))
            {
                double.TryParse(System.Web.HttpContext.Current.Request.Params[name], out value);
            }
            else
            {
                double.TryParse(System.Web.HttpContext.Current.Request.Form[name], out value);
            }
            return value;
        }

        public static decimal Decimal(string name)
        {
            decimal value = 0.0M;
            if (string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.Form[name]))
            {
                decimal.TryParse(System.Web.HttpContext.Current.Request.Params[name], out value);
            }
            else
            {
                decimal.TryParse(System.Web.HttpContext.Current.Request.Form[name], out value);
            }
            return value;
        }
    }
}
