using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Queue
{
   public class QueueUsingArray<T> : IEnumerable<T>
    {
        T[] list = new T[0];
        int size;

        /// <summary>
        /// Propety to check if Queue is Empty
        /// </summary>
        public bool IsEmpty
        {
            get { return size == 0; }
        }

        /// <summary>
        /// Property to check if Queue is Full
        /// </summary>
        public bool IsFull
        {
            get { return list.Length == size; }
        }

        /// <summary>
        /// Get the number of items in Queue
        /// </summary>
        public int Count
        {
            get { return size; }
        }

        /// <summary>
        /// Add a item to End of the Queue
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(T item)
        {
           if(IsFull || IsEmpty)
            {
                ResizeArray();
            }
            list[size] = item;
            size++;
        }
        
        /// <summary>
        /// Remove the item from front of the queue & return the remobed item.
        /// </summary>
        public T Dequeue()
        {
            if (size > 0)
            {
                T firstItem = list[0];

                T[] tempList = new T[size];

                for(int i =1; i < this.Count; i++)
                {
                    tempList[i-1] = list[i];
                }

                list = tempList;
                size--;
                return firstItem;
            }
            else
                throw new InvalidOperationException("Queue is empty.");
        }


        /// <summary>
        /// Method to get the first item from Queue
        /// </summary>
        public T Peek()
        {
            if (size > 0)
                return list[0];
            else
                throw new InvalidOperationException("Queue is IsEmpty");

        }

        /// <summary>
        /// Clear the items from the Queue
        /// </summary>
        public void Clear()
        {
            size = 0;
            list = new T[0];
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (T item in list)
            {
                yield return item;
            }
        }


        /// <summary>
        /// Resize Array if length is zero / or Array is full
        /// </summary>
        private void ResizeArray()
        {
            if(IsEmpty)
            {
                list = new T[4];

            }
            else  // i.e Array is full, we need to resize and copy the items again to original object
            {
                T[] tempArray = new T[size * 2];
                list.CopyTo(tempArray, 0);

                list = tempArray;
            }
        }

    }
}
