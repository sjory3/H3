using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Ingredient> ingredients = new List<Ingredient>()
                {
                    new Ingredient{Name = "lime juice",Type = "liquid",Alcohol = false},
                    new Ingredient{Name = "triple sec",Type = "liquid",Alcohol = false},
                    new Ingredient{Name = "tequila",Type = "liquid",Alcohol = true},
                    new Ingredient{Name = "dark rum",Type = "liquid",Alcohol = true}
                };

            using (var ctx = new BarContext())
            {
                foreach (var item in ingredients)
                {
                    ctx.ingredients.Add(item);
                }
                ctx.SaveChanges();

            }
        }
    }
}
