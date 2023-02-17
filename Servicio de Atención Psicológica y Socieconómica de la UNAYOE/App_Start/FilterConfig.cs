using System.Web;
using System.Web.Mvc;

namespace Servicio_de_Atención_Psicológica_y_Socieconómica_de_la_UNAYOE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
