using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Queue
{
    /// <summary>
    /// Class to represent a Queue.
    /// It works on FiFO : First In First Out Model
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QueueUsingLinkedList<T> : IEnumerable<T>
    {
        LinkedList<T> _list = new LinkedList<T>();

        /// <summary>
        /// Property to get the Count of items in Queue
        /// </summary>
        public int Count
        {
            get { return _list.Count; }
        }

        /// <summary>
        /// Method to add a item in Queue.
        /// It will add the item in end of the queue
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(T item)
        {
            _list.AddLast(item);

        }

        /// <summary>
        /// Method to remoge a item from Queue.
        /// It will remove the last item from the queue
        /// </summary>
        public T Dequeue()
        {
            if (_list.Count > 0)
            {
                T firstIItem = _list.First.Value;
                _list.RemoveFirst();

                return firstIItem;
            }
            else
                throw new InvalidOperationException("Queue is empty");
        }


        /// <summary>
        /// Method to get the first item from Queue
        /// </summary>
        public T Peek()
        {
            if(_list.Count > 0)
            return _list.First.Value;
            else
                throw new InvalidOperationException("Queue is IsEmpty");

        }

        /// <summary>
        /// Clear the items from the Queue
        /// </summary>
        public void Clear()
        {
            _list.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        
    }
}
