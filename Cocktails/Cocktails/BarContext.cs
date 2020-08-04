using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    public class BarContext:DbContext
    {
        public BarContext() : base()
        {
            //Database.SetInitializer<BarContext>(new DropCreateDatabaseAlways<BarContext>());
        }

        public DbSet<Drink> drinks { get; set; }
        public DbSet<Item> items { get; set; }
        public DbSet<Ingredient> ingredients { get; set; }

    }
}
