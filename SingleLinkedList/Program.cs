using System;

namespace SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            SinglyLinkedList<int> sll = new SinglyLinkedList<int>();
            sll.AddHead(1);
            sll.AddHead(2);
            sll.AddHead(3);
            sll.AddHead(100);

            sll.AddTail(103); // 100,3,2,1, 103
            sll.AddHead(11);   // 103, 100,3,2,1, 103

            foreach (var item in sll)
            {
                Console.WriteLine(item);
            }
        }
    }

}
