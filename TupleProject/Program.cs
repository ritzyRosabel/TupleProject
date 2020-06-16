using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Tuple.Create(12, "Miracle", "Oshey");
            DisplayResult(person);
            Console.ReadLine();
            //Miracle Oshey is 12 years old
        }

        private static void DisplayResult(Tuple<int, string, string> person)
        {
            Console.WriteLine($"{person.Item2} {person.Item3} is {person.Item1} years old");

        }
    }
}
