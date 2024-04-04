using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _PortfolioComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }  
    }
}
