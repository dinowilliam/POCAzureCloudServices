using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POCACSWebRole.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult NewPage() {
            ViewBag.Message = "Verificando Valores dos Controlers";

            var controller = RouteData.Values["controller"];
            var page = RouteData.Values["action"];
            var id = RouteData.Values["id"];

            var msg = String.Format("Controler: {0} Page: {1} ID: {2}", controller, page, id);

            ViewBag.Message = msg;

            return View();
        }
    }
}