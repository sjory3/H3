using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTest
{

    [Table("Cat")]
    public class Cat : Animal, IsCityAnimal
    {
        private int lives;
        public int Lives { get => lives; set => lives = value; }

        public Cat(int weight, double height, string race, int lives) : base(weight, height, race)
        {
            Lives = lives;
        }


        public bool allowedInHouse()
        {
            throw new NotImplementedException();
        }
    }
}
