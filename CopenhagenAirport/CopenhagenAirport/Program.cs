using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CopenhagenAirport
{
    class Program
    {
        public static List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
        static void Main(string[] args)
        {
            ListSorter(numbers);

            Console.ReadKey();
        }


        public static void ListSorter(List<int> numbers)
        {
            numbers.Sort();
            numbers.Reverse();
            Console.WriteLine(numbers[0]);
        }
    }
}
