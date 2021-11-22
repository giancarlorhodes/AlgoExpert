using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryGap
{
    //   https://app.codility.com/programmers/lessons/1-iterations/binary_gap/
    // A binary gap within a positive integer N is any maximal sequence of consecutive 
    // zeros that is surrounded by ones at both ends in the binary representation of N.
    // For example, number 9 has binary representation 1001 and contains a binary
    // gap of length 2. The number 529 has binary representation 1000010001 and 
    // contains two binary gaps: one of length 4 and one of length 3. The number 20
    // has binary representation 10100 and contains one binary gap of length 1. 
    // The number 15 has binary representation 1111 and has no binary gaps.The number
    // 32 has binary representation 100000 and has no binary gaps.

    public class MySolution
    {
        public MySolution() { }

        public int BinaryGapConvert(int value)
        {
            // convert to string
            string binary = Convert.ToString(value, 2);

            if (value == 0) return 0;

            //// split on 1s
            //var _split = binary.Split('1'); // string array
            //List<string> _cleaned = new List<string>();

            //// remove all strings that don't have a leading 1 and trailing 1
            //foreach (var item in _split)
            //{
            //    if (item.StartsWith('1') && item.EndsWith('1')) 
            //    {
            //        _cleaned.Add(item);
            //    }
            //}

            //// sort
            //string longest = _cleaned.OrderByDescending(s => s.Length).First();
            //// pick top one
            //return longest.Length - 2; // 

            // go char by char,

            // once you encounter a '1', start counting '0'

            return value;
        }
    }
}
