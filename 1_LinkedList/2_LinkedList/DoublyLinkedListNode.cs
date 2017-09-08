using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LinkedList._2_LinkedList
{
    /// <summary>
    /// Class to represent dobly Linked List Nodes
    /// It will have Previous Node, Next Node & Value of node.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DoublyLinkedListNode<T>
    {
        public T Value { get; set; }
        public DoublyLinkedListNode<T> Previous { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }

        public DoublyLinkedListNode()
        {

        }

        public DoublyLinkedListNode(T value)
        {
            Value =  value;
        }

       
    }
}
