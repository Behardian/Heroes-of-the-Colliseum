using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HeroesOfTheColliseumMvc.Models;

namespace HeroesOfTheColliseumMvc.Controllers
{
    public class HeroesController : Controller
    {
        private ApplicationDbContext _context;

        public HeroesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        
        public ViewResult Index()
        {
            var heroes = _context.Heroes.ToList();

            return View(heroes);
        }

        public ActionResult HeroDetails(int id)
        {
            var hero = _context.Heroes.SingleOrDefault(m => m.Id == id);

            if (hero == null)
                return HttpNotFound();

            return View(hero);
        }
    }
}