using System;
using System.Linq;
using System.Web.Mvc;
using HeroesOfTheColliseumMvc.Models;
using HeroesOfTheColliseumMvc.ViewModels;

namespace HeroesOfTheColliseumMvc.Controllers
{
    public class BattleController : Controller
    {       
        private ApplicationDbContext _context;

        public BattleController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }        

        public ActionResult Index()
        {
            var heroNames = _context.Heroes.ToList();
            var viewModel = new BattleViewModel();

            return View(viewModel);
        }

        public ViewResult CharacterSelect()
        {
          var heroes = _context.Heroes.ToList();

          return View(heroes);                      
        }
        
        public ActionResult BattleArena(int? id)
        {
            // Generate a random monster opponent
            Random random = new Random();
            
            var monsterId = random.Next(8);
            var monster = _context.Monsters.SingleOrDefault(m => m.Id == monsterId);
            var hero = _context.Heroes.SingleOrDefault(m => m.Id == id);            

            var model = new BattleViewModel { Monster = monster, Hero = hero };      

            return View(model);
        }

        public ActionResult Attack(int? id)
        {
            var hero = _context.Heroes.SingleOrDefault(m => m.Id == id);
            var monster = _context.Monsters.SingleOrDefault(m => m.Id == id);
            Random random = new Random();

            int AttackRoll = random.Next(hero.Attack);
            int DefenceRoll = random.Next(monster.Attack);
            int damage = 0;

            if (AttackRoll > DefenceRoll)
            {
                damage += random.Next(hero.CritDam);
                damage += hero.Attack - monster.Defence;
            }
            else
            {
                damage = 0;
            }
            int monsterHp = monster.HitPoints;
            monsterHp -= damage;
            monster.HitPoints = Convert.ToByte(monsterHp);

            var Monster = new MonsterViewModel { HitPoints = monster.HitPoints, };            

            return View(Monster);
        }
    }
}