using Microsoft.AspNetCore.Mvc;

namespace MIDAS_Fitness.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
