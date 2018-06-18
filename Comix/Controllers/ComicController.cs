using System.Web.Mvc;

namespace Comix.Controllers
{
    public class ComicController : Controller
    {
        // GET: Comic
        public ActionResult Index()
        {
            return View();
        }
    }
}