using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryGap
{
    public class MySolution
    {
        public MySolution() { }

        public int Solution2IntToInt(int value)
        {
            // convert to string
            string binary = Convert.ToString(value, 2);

            // split on 1s
            var _split = binary.Split('1'); // string array
            List<string> _cleaned = new List<string>();

            // remove all strings that don't have a leading 1 and trailing 1
            foreach (var item in _split)
            {
                if (item.StartsWith('1') && item.EndsWith('1')) 
                {
                    _cleaned.Add(item);
                }
            }

            // sort
            string longest = _cleaned.OrderByDescending(s => s.Length).First();
            // pick top one
            return longest.Length - 2; // 
        }
    }
}
