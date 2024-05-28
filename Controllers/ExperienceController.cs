using Microsoft.AspNetCore.Mvc;
using Portfolio.DAL.Context;
using Portfolio.DAL.Entities;

namespace Portfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var experience = _context.Experiences.ToList();
            return View(experience);
        }
        [HttpGet]
		public IActionResult AddExperience()
        { 
			return View();
		}
		[HttpPost]
		public IActionResult AddExperience(Experience experience)
		{
            _context.Experiences.Add(experience);
            _context.SaveChanges();
			return RedirectToAction("ExperienceList");   
		}
	}
}
