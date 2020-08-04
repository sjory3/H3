using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Liquid : Ingredient
    {
        private bool Alcohol { get; set; }

        public Liquid(bool alcohol, string name) : base (name)
        {
            Alcohol = alcohol;
        }
    }
}
