using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents.LayoutViewComponents
{
	public class _LayaoutHeadComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
