using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult ExperienceList()
        {
            return View();
        }
    }
}
