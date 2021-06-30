namespace SingleLinkedList
{
    public class SinglyLinkedNode<T>
    { 
              
        public SinglyLinkedNode<T> Next { get; set; }

        public T Value { get; set; }

        public SinglyLinkedNode(T inValue, SinglyLinkedNode<T> inNext = null)
        {
            this.Value = inValue;
            this.Next = inNext;
        }
    }

}
