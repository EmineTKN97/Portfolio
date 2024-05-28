using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents.LayoutViewComponents
{
	public class _LayaoutScriptComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			{
				return View();
			}
		}
	}
}
