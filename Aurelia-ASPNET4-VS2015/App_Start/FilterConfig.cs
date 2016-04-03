using System.Web;
using System.Web.Mvc;

namespace Aurelia_ASPNET4_VS2015
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
