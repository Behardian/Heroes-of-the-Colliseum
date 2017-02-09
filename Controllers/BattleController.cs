using System;
using System.Linq;
using System.Web.Mvc;
using HeroesOfTheColliseumMvc.Models;
using HeroesOfTheColliseumMvc.ViewModels;
using System.Text;

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
            return View();
        }        
        
        public ViewResult CharacterSelect()
        {
          var heroes = _context.Heroes.ToList();

          return View(heroes);                      
        }
        
        public ActionResult BattleArena(int? id)
        {           
            Random random = new Random();
            var monsterId = random.Next(8);           

            Monster arenaMonster = _context.Monsters.SingleOrDefault(m => m.Id == monsterId);
            Hero arenaHero = _context.Heroes.SingleOrDefault(m => m.Id == id);

            var battleViewModel = new BattleViewModel(arenaHero, arenaMonster);            
            
            return View(battleViewModel);        }                
        
        [HttpPost]
        public ActionResult Attack(int? id, int? mid)
        {
            var hero = _context.Heroes.SingleOrDefault(m => m.Id == id);
            var monster = _context.Monsters.SingleOrDefault(m => m.Id == mid);

            var attackBattleViewModel = new BattleViewModel(hero, monster);

            if (hero != null && monster != null)
            {                
                Dice newDice = new Dice();

                int heroDamage = attackBattleViewModel.Hero.AttackRoll(newDice);
                attackBattleViewModel.Monster.Defend(heroDamage);

                int monsterDamage = attackBattleViewModel.Monster.AttackRoll(newDice);
                attackBattleViewModel.Hero.Defend(monsterDamage);                

                return View(attackBattleViewModel);
            }
            else
            {
                return HttpNotFound();
            }
        }        
    }
}
