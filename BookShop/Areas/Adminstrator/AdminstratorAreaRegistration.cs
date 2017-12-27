using System.Web.Mvc;

namespace BookShop.Areas.Adminstrator
{
    public class AdminstratorAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Adminstrator";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Adminstrator_default",
                "Adminstrator/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },

               //Giải quyết xung đột controller
               namespaces: new string[] { "BookShop.Areas.Adminstrator.Controllers" }
            );
        }
    }
}