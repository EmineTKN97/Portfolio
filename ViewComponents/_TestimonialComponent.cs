using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _TestimonialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            { return View(); }
        }
    }
}
