using Microsoft.AspNetCore.Mvc;
using Portfolio.DAL.Context;

namespace Portfolio.ViewComponents
{
    public class _SkillComponent:ViewComponent
    {
        MyPortfolioContext _context= new MyPortfolioContext();
        public  IViewComponentResult Invoke() {
            var result = _context.Skills.ToList();
            return View(result); 

        } 
    }
}
