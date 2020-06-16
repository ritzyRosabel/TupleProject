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
                return tuple;
            //yet to find out the return type to use when i waant to return a Tuple
        }
    }
}
