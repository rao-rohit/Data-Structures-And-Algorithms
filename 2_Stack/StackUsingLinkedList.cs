using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Stack
{
    ///Stack is a LIFO data structure.

    /// <summary>
    /// Class to represent a Stack (Using Linked List)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class StackUsingLinkedList<T> : IEnumerable<T>
    {
        LinkedList<T> _list = new LinkedList<T>();
        

        /// <summary>
        /// Add a item on Top of List / Stack
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            _list.AddFirst(item);
        }


        /// <summary>
        /// Remove the top item from the stack and return removed value.
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (_list.Count > 0)
            {
                T previousTop = _list.First.Value;
                _list.RemoveFirst();
                return previousTop;
            }
            else
                throw new Exception("Stack is Empty.");
        }


        /// <summary>
        /// Get the top item's value.
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
           return _list.First.Value;

        }

        /// <summary>
        /// Enumerate the stack.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
           return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        /// <summary>
        /// Clear items from list (stack);
        /// </summary>
        public void Clear()
        {
            _list.Clear();
        }

        /// <summary>
        /// Get the total no. of items present in Stack
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return _list.Count;
        }
    }
}
