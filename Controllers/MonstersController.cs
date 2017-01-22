using HeroesOfTheColliseumMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HeroesOfTheColliseumMvc.Controllers
{
    public class MonstersController : Controller
    {
        private ApplicationDbContext _context;

        public MonstersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var monsters = _context.Monsters.ToList();

            return View(monsters);
        }

        public ActionResult MonsterDetails(int id)
        {
            var monster = _context.Monsters.SingleOrDefault(m => m.Id == id);

            if (monster == null)
                return HttpNotFound();

            return View(monster);
        }        
    }
}