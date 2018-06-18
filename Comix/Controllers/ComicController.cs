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
            Artist george = new Artist()
            {
                Name = "George Smith",
                Role = "Writer"
            };
            Artist jago = new Artist()
            {
                Name = "Jagoda Morys",
                Role = "Illustrator"
            };

            Comic comic = new Comic()
            {
                Title = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final Issue! Witness the final hours of Doctor Octopus' life and his one last great act of revenge! If Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]{george, jago}
        };

            ViewBag.ComicName = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final Issue! Witness the final hours of Doctor Octopus' life and his one last great act of revenge! If Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[] {"George Smith", "Jago Morys"};

            return View(comic);
        }
    }
}