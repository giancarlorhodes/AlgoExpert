using System;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {


            Solution1 s1 = new Solution1();
            Console.WriteLine("please enter the number you what to operate on: ");
            string input = Console.ReadLine();
            int a = s1.BinaryGapConvert(Convert.ToInt32(input));
            Console.WriteLine(a.ToString());


            MySolution s2 = new MySolution();
            Console.WriteLine("please enter the number you what to operate on: ");
            input = Console.ReadLine();
            a = s2.BinaryGapConvert(Convert.ToInt32(input));
            Console.WriteLine(a.ToString());



            Console.ReadLine();

        }
    }
}
