using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeroesOfTheColliseumMvc.Models
{
    public class Dice
    {
        public int Sides { get; set; }

        Random random = new Random();
        public int Roll()
        {
            return random.Next(Sides);
        }
    }
}