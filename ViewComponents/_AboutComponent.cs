﻿using Microsoft.AspNetCore.Mvc;
using Portfolio.DAL.Context;

namespace Portfolio.ViewComponents
{
    public class _AboutComponent:ViewComponent
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = _context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = _context.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetails = _context.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }  
    }
}
