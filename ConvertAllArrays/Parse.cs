using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertAllArrays
{
    class Parse {


        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        public string[] ParseArray(object[] inArray) 
        {
            List<string> temp = new List<string>();


           

            // add implementation here

            // take each element


            // if number, convert it and store it list

            // if string, no conversion needed, just store

            foreach (var item in inArray)
            {            
                if (this.IsNumeric(item.ToString()))
                {
                    temp.Add(item.ToString());

                    temp.Remove(item.ToString());
                    if (temp.Contains(item)) 
                    { 
                        
                    }


                    

                }
                else {
                    temp.Add(item.ToString());                
                } 
            }

            return temp.ToArray();

        }


    }
}
