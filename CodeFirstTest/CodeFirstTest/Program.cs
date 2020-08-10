using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new AnimalContext())
            {
                Cow cow = new Cow(200,100,"Cow", "JHC2173");
                Cat cat = new Cat(23,2,"Cat", 9);
                Dog dog = new Dog(54,3,"Dog", true);

                ctx.cats.Add(cat);
                ctx.dogs.Add(dog);
                ctx.cows.Add(cow);
                ctx.SaveChanges();
            }
        }
    }
}
