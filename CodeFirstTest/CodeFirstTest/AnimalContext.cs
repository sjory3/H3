using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTest
{
    public class AnimalContext : DbContext
    {
        public AnimalContext() : base()
        {

        }

        public DbSet<Animal> animals { get; set; }
        public DbSet<Cat> cats { get; set; }
        public DbSet<Dog> dogs { get; set; }
        public DbSet<Cow> cows { get; set; }
    }
}
