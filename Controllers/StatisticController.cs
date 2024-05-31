using Microsoft.AspNetCore.Mvc;
using Portfolio.DAL.Context;

namespace Portfolio.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext _context = new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.skills = _context.Skills.Count();
			ViewBag.allmessage = _context.Messages.Count();
			ViewBag.readmessage = _context.Messages.Where( x => x.IsRead == true).Count();
			ViewBag.notreadmessage = _context.Messages.Where( x => x.IsRead == false).Count();
			ViewBag.experiences= _context.Experiences.Count();
			ViewBag.projects= _context.Projects.Count();	

			return View();
		}
	}
}
