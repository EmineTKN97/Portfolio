using Microsoft.AspNetCore.Mvc;
namespace Portfolio.ViewComponents.LayoutViewComponents
{
	public class _LayaoutSlideBarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
		return View();
		}
	}
}
