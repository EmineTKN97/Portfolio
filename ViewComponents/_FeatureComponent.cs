using Microsoft.AspNetCore.Mvc;
using Portfolio.DAL.Context;

namespace Portfolio.ViewComponents
{
    public class _FeatureComponent:ViewComponent
    {
       MyPortfolioContext _context = new MyPortfolioContext();


        public IViewComponentResult Invoke()
        {
           var result= _context.Features.ToList();
            return View(result); 
        }  
    }
}
