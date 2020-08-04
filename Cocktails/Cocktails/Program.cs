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
                    new Ingredient{Name = "triple sec",Type = "liquid",Alcohol = true},
                    new Ingredient{Name = "tequila",Type = "liquid",Alcohol = true},
                    new Ingredient{Name = "white rum",Type = "liquid",Alcohol = true},
                    new Ingredient{Name = "dark rum",Type = "liquid",Alcohol = true},
                    new Ingredient{Name = "kahlua",Type = "liquid",Alcohol = true},
                    new Ingredient{Name = "cachaca",Type = "liquid",Alcohol = true},
                    new Ingredient{Name = "vodka",Type = "liquid",Alcohol = true},
                    new Ingredient{Name = "bourbon",Type = "liquid",Alcohol = true},
                    new Ingredient{Name = "Italia sweet vermouth",Type = "liquid",Alcohol = true},
                    new Ingredient{Name = "french dry vermouth",Type = "liquid",Alcohol = true},
                    new Ingredient{Name = "cointreau",Type = "liquid",Alcohol = true},
                    new Ingredient{Name = "gin",Type = "liquid",Alcohol = true},
                    new Ingredient{Name = "sloe gin",Type = "liquid",Alcohol = true},
                    new Ingredient{Name = "prosecco",Type = "liquid",Alcohol = true},
                    new Ingredient{Name = "orange curacao",Type = "liquid",Alcohol = true},
                    new Ingredient{Name = "cherry brandy",Type = "liquid",Alcohol = true},

                    new Ingredient{Name = "lime",Type = "fruit",Alcohol = false},
                    new Ingredient{Name = "orange",Type = "fruit",Alcohol = false},
                    new Ingredient{Name = "cherry",Type = "fruit",Alcohol = false},
                    new Ingredient{Name = "olive",Type = "fruit",Alcohol = false},
                    new Ingredient{Name = "pineapple",Type = "fruit",Alcohol = false},

                    new Ingredient{Name = "brown sugar",Type = "addable other",Alcohol = false},
                    new Ingredient{Name = "celery",Type = "addable other",Alcohol = false},
                    new Ingredient{Name = "mint",Type = "addable other",Alcohol = false},
                    new Ingredient{Name = "coconut cream",Type = "addable other",Alcohol = false},
                    new Ingredient{Name = "fresh cream",Type = "addable other",Alcohol = false},
                    new Ingredient{Name = "ice cube",Type = "addable other",Alcohol = false},

                    new Ingredient{Name = "lime juice",Type = "liquid",Alcohol = false},
                    new Ingredient{Name = "almond syrup",Type = "liquid",Alcohol = false},
                    new Ingredient{Name = "orange juice",Type = "liquid",Alcohol = false},
                    new Ingredient{Name = "tomato juice",Type = "liquid",Alcohol = false},
                    new Ingredient{Name = "water",Type = "liquid",Alcohol = false},
                    new Ingredient{Name = "cranberry juice",Type = "liquid",Alcohol = false},
                    new Ingredient{Name = "lemon juice",Type = "liquid",Alcohol = false},
                    new Ingredient{Name = "pineapple juice",Type = "liquid",Alcohol = false},
                    new Ingredient{Name = "grapefruit juice",Type = "liquid",Alcohol = false},
                    new Ingredient{Name = "cola",Type = "liquid",Alcohol = false},
                    new Ingredient{Name = "peach puree",Type = "liquid",Alcohol = false}
                };
            using (var ctx = new BarContext())
            {

                foreach (var item in ingredients)
                {
                    ctx.ingredients.Add(item);
                }
                
                Drink margarita = new Drink()
                {
                    Name = "Margarita",
                    items = new List<Item>(){
                        new Item{ml = 60, ingredient = ctx.ingredients.Find(28)},
                        new Item{ml = 30,ingredient = ctx.ingredients.Find(1)},
                        new Item{ml = 60, ingredient = ctx.ingredients.Find(2)},
                        new Item{ml = 1, ingredient = ctx.ingredients.Find(27)},
                        new Item{ml = 1, ingredient = ctx.ingredients.Find(17)}
                    }
                };

                ctx.drinks.Add(margarita);
                ctx.SaveChanges();

            }
        }
    }
}
