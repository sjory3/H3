using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Accessory : Ingredient
    {
        private string type { get; set; }
        public Accessory(string type, string name) : base(name)
        {
            this.type = type;
        }

    }
}
