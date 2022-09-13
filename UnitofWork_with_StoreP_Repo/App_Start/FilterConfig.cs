using System.Web;
using System.Web.Mvc;

namespace UnitofWork_with_StoreP_Repo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
