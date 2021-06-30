using System;
using System.Collections.Generic;
using System.Text;

namespace firstalgos
{
    public class Palindrome : IPalindrome
    {
        public bool TestForPalindromeless(string somestring)
        {
            // radar is odd number of characters, middle char does not to checked

            // even is even number of characters, no middle char

            // need to loop until two indexes have reached half point

            int _len = string.IsNullOrEmpty(somestring) ? 0 : somestring.Length;           
            bool _return = true;

            if (_len <= 2) return true; // empty, c, ca, null
            int _front = 0;
            int _end = _len - 1;

            while (_front < _end)
            {
                if (somestring[_front] != somestring[_end])
                { 
                    _return = false;
                    return _return;
                }
                _front++;
                _end--;               
            }

            return _return;
        }
    }
}
