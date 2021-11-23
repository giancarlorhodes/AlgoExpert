using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            const int _size_small = 100;
            const int _size_medium = 1000; // is it 10x of small??
            const int _size_large = 10000;


            Console.WriteLine("STARTING....");
            BubbleSort _bsSmall = new BubbleSort(_size_small);
            var watch = System.Diagnostics.Stopwatch.StartNew();
            _bsSmall.Sort(SortBy.Descending);
            watch.Stop();

            for (int i = 0; i < _size_small; i++)
            {
                Console.WriteLine(_bsSmall.InputArray[i]);
            }
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

            Console.WriteLine();
            Console.WriteLine();

            watch = System.Diagnostics.Stopwatch.StartNew();
            _bsSmall.Sort(SortBy.Ascending);
            watch.Stop();
            for (int i = 0; i < _size_small; i++)
            {
                Console.WriteLine(_bsSmall.InputArray[i]);
            }
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

            BubbleSort _bsMedium = new BubbleSort(_size_medium);
            watch = System.Diagnostics.Stopwatch.StartNew();
            _bsMedium.Sort(SortBy.Descending);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");



            BubbleSort _bsLarge = new BubbleSort(_size_large);
            watch = System.Diagnostics.Stopwatch.StartNew();
            _bsLarge.Sort(SortBy.Descending);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

            Console.WriteLine("STOPPING....");
            Console.ReadLine();
        }
    }


    enum SortBy {

        Descending, // 200, 100, 99, 1
        Ascending  // 1, 99, 100, 200
    }
}
