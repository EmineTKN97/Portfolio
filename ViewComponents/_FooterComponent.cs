using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _FooterComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
