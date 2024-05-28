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
	
		public IActionResult DeleteExperience(int id)
		{
			var experience= _context.Experiences.Find(id);
			_context.Experiences.Remove(experience);
			_context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
		[HttpGet]
		public IActionResult UpdateExperience(int id)
		{
			var value = _context.Experiences.Find(id);
			return View();
		}
		[HttpPut]
		public IActionResult UpdateExperience()
		{
			var experience = _context.Experiences.Find();
			_context.Experiences.Remove(experience);
			_context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
	}
}
