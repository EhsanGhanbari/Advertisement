using System.Web.Mvc;
using System.Web.Routing;

namespace Advertisement.Web.Mvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            AboutUs(routes);
            ContactUs(routes);
            Services(routes);
            Campains(routes);
            Softwares(routes);
            Customers(routes);

            routes.MapRoute(
                 "Default", "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new[] { "Advertisement.Web.Mvc.Controllers" }
            );
        }


        public static void AboutUs(RouteCollection routes)
        {
            routes.MapRoute(
                 "AboutUs-en", "AboutUs",
                new { controller = "Home", action = "AboutUs", id = UrlParameter.Optional },
                new[] { "Advertisement.Web.Mvc.Controllers" }
            );
            routes.MapRoute(
                 "AboutUs-fa", "درباره ما",
                new { controller = "Home", action = "AboutUs", id = UrlParameter.Optional },
                new[] { "Advertisement.Web.Mvc.Controllers" }
            );
            routes.MapRoute(
                 "AboutUs-fa-1", "درباره‌ما",
                new { controller = "Home", action = "AboutUs", id = UrlParameter.Optional },
                new[] { "Advertisement.Web.Mvc.Controllers" }
            );
        }

        public static void ContactUs(RouteCollection routes)
        {
            routes.MapRoute(
                 "ContactUs-en", "ContactUs",
                new { controller = "Home", action = "ContactUs", id = UrlParameter.Optional },
                new[] { "Advertisement.Web.Mvc.Controllers" }
            );
            routes.MapRoute(
                 "ContactUs-fa", "تماس با ما",
                new { controller = "Home", action = "ContactUs", id = UrlParameter.Optional },
                new[] { "Advertisement.Web.Mvc.Controllers" }
            );
            routes.MapRoute(
                 "ContactUs-fa-1", "تماس‌با‌ما",
                new { controller = "Home", action = "ContactUs", id = UrlParameter.Optional },
                new[] { "Advertisement.Web.Mvc.Controllers" }
            );
        }

        public static void Services(RouteCollection routes)
        {
            routes.MapRoute(
                 "Services-en", "Services",
                new { controller = "Services", action = "Index", id = UrlParameter.Optional },
                new[] { "Advertisement.Web.Mvc.Controllers" }
            );
            routes.MapRoute(
                 "Services-fa", "خدمات",
                new { controller = "Services", action = "Index", id = UrlParameter.Optional },
                new[] { "Advertisement.Web.Mvc.Controllers" }
            );
        }

        public static void Campains(RouteCollection routes)
        {
            routes.MapRoute(
                 "Campains-en", "Campains",
                new { controller = "Campain", action = "Index", id = UrlParameter.Optional },
                new[] { "Advertisement.Web.Mvc.Controllers" }
            );
            routes.MapRoute(
                 "Campains-fa", "کمپین ها",
                new { controller = "Campain", action = "Index", id = UrlParameter.Optional },
                new[] { "Advertisement.Web.Mvc.Controllers" }
            );
            routes.MapRoute(
                 "Campains-fa-1", "کمپین‌ها",
                new { controller = "Campain", action = "Index", id = UrlParameter.Optional },
                new[] { "Advertisement.Web.Mvc.Controllers" }
            );
        }

        public static void Softwares(RouteCollection routes)
        {
            routes.MapRoute(
                 "Softwares-en", "Softwares",
                new { controller = "Softwares", action = "Index", id = UrlParameter.Optional },
                new[] { "Advertisement.Web.Mvc.Controllers" }
            );
            routes.MapRoute(
                 "Softwares-fa", "نرم افزار ها",
                new { controller = "Softwares", action = "Index", id = UrlParameter.Optional },
                new[] { "Advertisement.Web.Mvc.Controllers" }
            );
            routes.MapRoute(
                 "Softwares-fa-1", "نرم‌افزارها",
                new { controller = "Softwares", action = "Index", id = UrlParameter.Optional },
                new[] { "Advertisement.Web.Mvc.Controllers" }
            );
        }

        public static void Customers(RouteCollection routes)
        {
            routes.MapRoute(
                 "Customers-en", "Customers",
                new { controller = "Customers", action = "Index", id = UrlParameter.Optional },
                new[] { "Advertisement.Web.Mvc.Controllers" }
            );
            routes.MapRoute(
                 "Customers-fa", "مشتریان",
                new { controller = "Customers", action = "Index", id = UrlParameter.Optional },
                new[] { "Advertisement.Web.Mvc.Controllers" }
            );
            routes.MapRoute(
                 "Customers-fa-1", "مشتريان",
                new { controller = "Customers", action = "Index", id = UrlParameter.Optional },
                new[] { "Advertisement.Web.Mvc.Controllers" }
            );
        }
    }
}
