using System.Web.Mvc;

namespace FilmDatabas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // this is view
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}