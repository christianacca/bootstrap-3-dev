using System.Web;
using System.Web.Mvc;

namespace bootstrap_3._0._2_dev
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}