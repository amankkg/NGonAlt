using System.Web.Mvc;

namespace NGon.Sample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new NGonActionFilterAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
