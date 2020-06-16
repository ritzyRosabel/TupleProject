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
        //limitation of tuple
        //Tuple is a reference type and not a value type. It allocates on heap and could result in CPU intensive operations.
        //Tuple is limited to include 8 elements. You need to use nested tuples if you need to store more elements. However, this may result in ambiguity.
        //Tuple elements can be accessed using properties with a name pattern Item<elementNumber> which does not make sense.

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
