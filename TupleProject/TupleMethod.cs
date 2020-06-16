using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TupleProject
{
    public class TupleMethod
    {
        public static Object  TupleM()
        {
            int count = 3;
            string colors = "green white green";
            Tuple <int, string, string> tuple = new Tuple<int, string, string>(1, "Kemi", "Kolade");
            var sample = Tuple.Create<int, string>(22, "age");//Tuple static helper class
            var samples = Tuple.Create(224, "aged");//Tuple static helper class2
            var sample3 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);// can only take 8 elements per instance. creates a compile time error if more than 8
            _ = sample.Item1;
            _ = sample.Item2;//use Item1-7 to access elements in the tuple use Rest for the 8th element if up to eight.
            _ = sample3.Item1;
            _ = sample3.Item2;
            _ = sample3.Item3;
            _ = sample3.Item4;
            _ = sample3.Item5;
            _ = sample3.Item6;
            _ = sample3.Item7;
            _ = sample3.Rest;

                return tuple;
            //yet to find out the return type to use when i waant to return a Tuple
        }
    }
}
