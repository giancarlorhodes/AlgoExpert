using System;
using System.Collections;
using System.Collections.Generic;

namespace SingleLinkedList
{
    public class SinglyLinkedList<T> : ICollection<T>
    {
        // the first node on the list also referred to as the head
        public SinglyLinkedNode<T> Head { get; set; }

        public int Count { get; private set; }

        public bool IsReadOnly { get; private set; }

        public void AddHead(T item) 
        {
            Add(item);
        
        }

        public void AddTail(T item)
        {
            SinglyLinkedNode<T> _currentNode = this.Head;

            // transerve the list and get the end
            while (_currentNode.Next != null)
            {
                _currentNode = _currentNode.Next;
            }

            // you reached the end
            _currentNode.Next = new SinglyLinkedNode<T>(item);
            Count++;
            // add your tail node
            
        
        }

        // add head, first node of list
        public void Add(T item)
        {
            // is the head null, if yes, this is first node
            if (this.Head == null)
            {
                this.Head = new SinglyLinkedNode<T>(item, null);
                Count++;
            }
            else
            {
                SinglyLinkedNode<T> _newhead = new SinglyLinkedNode<T>(item, this.Head);
                this.Head = _newhead;
                Count++;
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
            SinglyLinkedNode<T> _current = Head;

            while (_current != null)
            {
                yield return _current.Value;
                _current = _current.Next;
            }
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
