using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LinkedList._2_LinkedList
{
    public class CircularLinkedListNode<T>
    {
        public T Value { get; set; }

        public CircularLinkedListNode<T> Next { get; set; }

        public CircularLinkedListNode()
        {

        }

        public CircularLinkedListNode(T value)
        {
            Value = value;
        }


    }
}
