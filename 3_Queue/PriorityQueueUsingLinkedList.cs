using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Queue
{
    //i/ <summary>
    /// Class to represent a priority queue.
    /// In this the higher priority item will come before low priority item. Insertion / Deletion
    /// </summary>
    public class PriorityQueueUsingLinkedList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        LinkedList<T> list = new LinkedList<T>();
        T current;
        public PriorityQueueUsingLinkedList()
        {

        }

        public void Enqueue(T item)
        {
            if (list.Count == 0)
                list.AddFirst(item);
            else
            {
                var current = list.First;
                while (current != null && current.Value.CompareTo(item) > 0)
                {
                    current = current.Next;
                }

                if (current == null)
                    list.AddLast(item);
                else
                    list.AddBefore(current, item);
                
            }


        }

        public T Dequeue()
        {
            if (list.Count > 0)
            {
                T item = list.First.Value;

                list.RemoveFirst();

                return item;
            }
            else
                throw new InvalidOperationException("Queue is Empty");

        }

        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
