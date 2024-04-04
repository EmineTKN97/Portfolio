using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _FeatureComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }  
    }
}
