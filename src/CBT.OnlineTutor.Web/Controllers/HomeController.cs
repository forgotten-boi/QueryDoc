using Microsoft.AspNetCore.Mvc;

namespace CBT.OnlineTutor.Web.Controllers
{
    public class HomeController : OnlineTutorControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}