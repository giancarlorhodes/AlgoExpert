using System;
using System.Collections.Generic;
using System.Text;

namespace firstalgos
{
    public class VUInterview
    {
        // write a function solution that, given a string S consisting on N 
        // letters 'a' and/ 'b' returns true
        // when all occurrences of letter 'a' are before all occurrences of letter 'b'

        // otherwise return false
        public bool CheckString(string value)
        {
            // a's before b's return true

            // otherwise return false

            int _current = 0;

            if (value == null)
                return false;
            else if (value.Length == 1 && (value[_current] == 'a' || value[_current] == 'b'))
                return true;          
            else
            {              
                // a least two char
                foreach (char c in value)
                {
                    // if second or greater char
                    if (_current != 0)
                    {
                        if (c == 'a')
                        {
                            if (value[_current - 1] == 'b')
                                return false;
                        }
                    }
                    _current = _current + 1;
                }
                return true;
            }
        }
    }
}
