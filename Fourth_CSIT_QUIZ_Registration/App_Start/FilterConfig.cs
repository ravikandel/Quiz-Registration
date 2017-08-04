using System.Web;
using System.Web.Mvc;

namespace Fourth_CSIT_QUIZ_Registration
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
