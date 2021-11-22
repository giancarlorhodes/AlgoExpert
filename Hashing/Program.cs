using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i < 100; i++)
            {
                Guid g = Guid.NewGuid();

                string _hashed = Hash.sha256_hash(g.ToString());
                Console.WriteLine("Guid is " + g.ToString() + ", Hash is "
                    + _hashed.ToString());

            }

            // Guid is ac5fb2db-b0ea-48f3-8e9d-e6c20fbb69fb, 
            // Hash is d7b77af00a2dfe1c074b4450a21f3ae40588f2a060355d7b0762f2ae5f454911

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
               

                string _hashed = Hash.sha256_hash("ac5fb2db - b0ea - 48f3 - 8e9d - e6c20fbb69fb");
                Console.WriteLine("Guid is " + "ac5fb2db-b0ea-48f3-8e9d-e6c20fbb69fb, Hash is "
                    + _hashed.ToString());

            }

            Console.ReadLine();

        }

       
    }
}
