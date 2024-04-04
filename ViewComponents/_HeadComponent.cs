using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _HeadComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }  
    }
}
