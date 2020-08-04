using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    public class Drink
    {
        //public Drink(List<Ingredient> ingredients, string name)
        //{
        //    this.ingredients = ingredients;
        //    Name = name;
        //}

        //empty construcktor because.....entityFramework
        //public Drink()
        //{
        //}
        [Key]
        public int drinkID { get; set; }

        public List<Item> items { get; set; }
        public string Name { get; set; }
    }
}
