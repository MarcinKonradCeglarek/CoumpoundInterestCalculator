#region Usings

using System.Web.Mvc;
using RedingtonMiniProject.ViewModels;

#endregion

namespace RedingtonMiniProject.Controllers
{
    public class RedingtonController : Controller
    {
        public ActionResult Index()
        {
            return View(new ProbabilityCalculatorViewModel {A = 0.5, B = 0.5});
        }

        public ActionResult About()
        {
            return View();
        }
    }
}