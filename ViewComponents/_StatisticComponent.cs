using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _StatisticComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
