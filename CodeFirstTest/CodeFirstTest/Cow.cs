using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTest
{
    [Table("Cows")]
    public class Cow : Animal
    {
        private string tag;
        public string Tag { get => tag; set => tag = value; }

        public Cow(int weight, double height, string race, string tag) : base(weight, height, race)
        {
            Tag = tag;
        }

    }
}
