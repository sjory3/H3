﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    public class Ingredient
    {
        [Key]
        public int ingredientsID { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }
        public bool Alcohol { get; set; }
    }
}
