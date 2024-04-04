using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _AboutComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }  
    }
}
