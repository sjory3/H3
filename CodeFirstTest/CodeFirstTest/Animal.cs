using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTest
{
    public abstract class Animal
    {
        private int weight;
        private double height;
        private string race;
        private int id;
        protected Animal(int weight, double height, string race)
        {
            Weight = weight;
            Height = height;
            Race = race;
        }

        public int Weight { get => weight; set => weight = value; }
        public double Height { get => height; set => height = value; }
        public string Race { get => race; set => race = value; }

        public int Id { get => id; set => id = value; }
    }
}
