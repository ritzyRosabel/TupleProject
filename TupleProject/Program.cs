using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleProject
{
    class Program
    {
        //Tuple
        //use tuple when
        //When you want to return multiple values from a method without using ref or out parameters.
        //When you want to pass multiple values to a method through a single parameter.
        //When you want to hold a database record or some values temporarily without creating a separate class.
        static void Main(string[] args)
        {
            var person = Tuple.Create(12, "Miracle", "Oshey");
            DisplayResult(person);
           Console.WriteLine( GetTuple(person));//(12, Miracle, Oshey)

            Console.ReadLine();
            //Miracle Oshey is 12 years old
        }

        private static Tuple<int,string,string> GetTuple(Tuple<int, string, string> person)
        {
            return person;
        }

        private static void DisplayResult(Tuple<int, string, string> person)
        {
            Console.WriteLine($"{person.Item2} {person.Item3} is {person.Item1} years old");

        }
    }
}
