using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _SkillComponent:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); } 
    }
}
