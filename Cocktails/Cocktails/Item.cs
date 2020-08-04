using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    public class Item
    {
        //public Item(int ml, Ingredient ingredient)
        //{
        //    this.ml = ml;
        //    this.ingredient = ingredient;
        //}
        ////empty construcktor because.....entityFramework
        //public Item()
        //{

        //}
        [Key]
        public int itemID { get; set; }
        public int ml { get; set; }
        public Ingredient ingredient { get; set; }
    }
}
