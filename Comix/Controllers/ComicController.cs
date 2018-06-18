using System.Web.Mvc;
using Comix.Models;

namespace Comix.Controllers
{
    public class ComicController : Controller
    {
        // GET: Comic
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {
            ViewBag.ComicName = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final Issue! Witness the final hours of Doctor Octopus' life and his one last great act of revenge! If Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[] {"George Smith", "Jago Morys"};

            return View();
        }
    }
}