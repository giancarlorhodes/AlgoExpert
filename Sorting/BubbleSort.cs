using System;

namespace Sorting
{
    internal class BubbleSort : IRandomize
    {
        private int[] inputArray;
        public Random random { get; set; }
        public int[] InputArray { get => inputArray; set => inputArray = value; }

        public BubbleSort(int size)
        {
            this.random = new Random();
            this.inputArray = this.RandomIntegers(size, Int32.MinValue, Int32.MaxValue);
            
        }

        public BubbleSort(int[] inputArray)
        {
            this.random = new Random();
            this.inputArray = inputArray;

        } 

        public int[] RandomIntegers(int length, int min, int max)
        {
            int[] _returnArray = new int[length];
            //Random _r = new Random();


            for (int i = 0; i < _returnArray.Length; i++)
            {
                _returnArray[i] = random.Next(min, max);
            }

            return _returnArray;
        }

        internal void Sort(SortBy inSort)
        {
            bool _flipped = false;
            do
            {
                // go element by element until the end of array
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inSort == SortBy.Descending)  // 99, 45, 23 etc.
                    {
                        if (i < inputArray.Length - 1) // check out of bounds error 
                        { 
                            if (inputArray[i] < inputArray[i + 1])    // flip them
                            {
                                // flip them                           
                                int _temp = inputArray[i];
                                inputArray[i] = inputArray[i + 1];
                                inputArray[i + 1] = _temp;
                                _flipped = true;
                                break;
                            }
                            else
                            {
                                _flipped = false;
                            }
                        }
                    }
                    else
                    {
                        if (i < inputArray.Length - 1) // check out of bounds error 
                        {
                            if (inputArray[i] > inputArray[i + 1])    // flip them
                            {
                                // flip them                           
                                int _temp = inputArray[i];
                                inputArray[i] = inputArray[i + 1];
                                inputArray[i + 1] = _temp;
                                _flipped = true;
                                break;
                            }
                            else
                            {
                                _flipped = false;
                            }
                        }

                    }
                }
            } while (_flipped);
                      
        }

       
    }
}