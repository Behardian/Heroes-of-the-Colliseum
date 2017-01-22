using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HeroesOfTheColliseumMvc.Models;

namespace HeroesOfTheColliseumMvc.ViewModels
{
    public class BattleViewModel
    {
        public Monster Monster { get; set; }
        public Hero Hero { get; set; }
    }
}