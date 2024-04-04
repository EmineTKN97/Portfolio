using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _ExperienceComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }  
    }
}
