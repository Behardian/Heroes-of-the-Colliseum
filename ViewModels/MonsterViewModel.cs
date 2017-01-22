using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HeroesOfTheColliseumMvc.Models;

namespace HeroesOfTheColliseumMvc.ViewModels
{
    public class MonsterViewModel
    {
        public byte Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public byte Attack { get; set; }
        public byte Defence { get; set; }
        public byte CritDam { get; set; }
        public byte HitPoints { get; set; }
    }
}