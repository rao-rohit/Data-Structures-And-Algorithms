using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LinkedList._2_LinkedList
{
    /// <summary>
    /// Class to represent a linked list node
    /// Generic class so it can be used with any datatype
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }

        //Constructors
        public LinkedListNode(T value)
        {
            Value = value;
        }

        public LinkedListNode()
        {
            
        }
        public LinkedListNode(T value, LinkedListNode<T> next)
        {
            Value = value;
            Next = next;
        }
    }
}
