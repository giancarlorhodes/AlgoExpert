using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertAllArrays
{
    class Program
    {
        static void Main(string[] args)
        {



            // Create a function that takes an array of integers and strings, converts integers to strings, 
            // and returns the array as a string array.

            //Examples
            //ParseArray([1, 2, "a", "b"]) ➞ ["1", "2", "a", "b"]

            //ParseArray(["abc", 123, "def", 456]) ➞ ["abc", "123", "def", "456"]

            //ParseArray([1, 2, 3, 17, 24, 3, "a", "123b"]) ➞ ["1", "2", "3", "17", "24", "3", "a", "123b"]

            //ParseArray([]) ➞ []

            Parse p = new Parse();
            object[] o = new object[4];
            o[0] = 1;
            o[1] = 100;
            o[2] = "aaa";
            o[3] = "b";

            string[] _return = p.ParseArray(o);


            foreach (var item in _return)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
