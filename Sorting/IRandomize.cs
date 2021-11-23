using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    interface IRandomize
    {

        Random random { get; set; }

        int[] RandomIntegers(int length, int min, int max);

    }
}
