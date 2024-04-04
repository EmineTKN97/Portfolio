using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _ContactComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
