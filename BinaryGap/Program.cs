using System;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {

            Gap s1 = new Gap();
            Console.WriteLine("please enter the number you what to operate on: ");
            string input = Console.ReadLine();
            int a = s1.BinaryGapConvert(Convert.ToInt32(input));
            Console.WriteLine(a.ToString());


            //SimplerGap s2 = new SimplerGap();
            //Console.WriteLine("please enter the number you what to operate on: ");
            //input = Console.ReadLine();
            //a = s2.BinaryGapConvert(Convert.ToInt32(input));
            //Console.WriteLine(a.ToString());

            Console.ReadLine();

        }
    }
}
