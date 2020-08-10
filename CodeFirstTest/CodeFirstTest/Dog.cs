using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTest
{
    [Table("Dogs")]
    public class Dog : Animal, IsCityAnimal
    {
        private bool goodBoi;
        public bool GoodBoi { get => goodBoi; set => goodBoi = value; }

        public Dog(int weight, double height, string race, bool goodBoi) : base(weight, height, race)
        {
            GoodBoi = goodBoi;
        }


        public bool allowedInHouse()
        {
            throw new NotImplementedException();
        }
    }
}
