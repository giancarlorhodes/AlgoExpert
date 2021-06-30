using System;
using System.Collections;
using System.Collections.Generic;

namespace SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class SinglyLinkedNode<T>
    { 
              
        public SinglyLinkedNode<T> Next { get; set; }

        public T Value { get; set; }

        public SinglyLinkedNode(T inValue)
        {

            this.Value = inValue;
        }
    }


    public class SinglyLinkedList<T> : ICollection<T>
    {
        // the first node on the list also referred to as the head
        public SinglyLinkedNode<T> Head { get; set; }

        public int Count { get; private set; }

        public bool IsReadOnly { get; private set; }

        public void Add(T item)
        {
            // is the head null, if yes, this is first node
            if (this.Head == null)
            {
                this.Head = new SinglyLinkedNode<T>(item);
                Count++;
            }
            else
            {
                // tranverse the list until to get to end
                SinglyLinkedNode<T> _current = Head;
                while (_current != null)
                { 
                    
                
                }

                // add node to end with changed null reference to the new code

            }
                
                               
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
