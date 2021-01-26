using System.Web;
using System.Web.Mvc;

namespace Diler_Holding_Varlik_Envater
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
