using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Queue
{
    public class QueueUsingArrayBetter<T> : IEnumerable<T>
    {
        T[] list = new T[0];
        public int head = -1;
        public int tail = -1;

        int size = 0;
        public bool IsEmpty
        {
            get { return size == 0; }
        }

        public bool IsFull
        {
            get
            {
                return size == list.Length;
            }
        }

        public int Count
        {
            get { return size; } 
        }


        public void Enqueue(T item)
        {
            if (IsEmpty || IsFull)
            {
                ResizeArray();
            }
            
            if(tail >= head  && tail < list.Length - 1) // Add to end
            {
                list[size] = item;
                tail = size;
            }
            else if(head > 0 && tail == list.Length-1) // Add to first and set it as tail : When we removed some items and head is not on 0th index
            {
                list[0] = item;
                tail = 0;
            }
            else if((head - tail) > 1)
            {
                list[tail + 1] = item;
                tail = tail +1;
            }
            size++;
        }

        public T Dequeue()
        {
            if (size > 0)
            {
                T item = list[head];

                if (head == tail)
                    Clear();
                else if (head < list.Length - 1 && size > 1)
                {
                    head = head + 1;
                    size--;
                }
                else if (head > tail)
                {
                    head = 0;
                    size--;
                }
                else
                    Clear();

                

                return item;
            }
            else
                throw new InvalidOperationException("Queue is empty");
        }

        public void Clear()
        {
            size = 0;
            head = -1;
            tail = -1;
            list = new T[0];
        }

        public void ResizeArray()
        {
            if (IsEmpty)
            {
                list = new T[4];
                head = 0;
                tail = 0;
            }
            else
            {
                T[] tempList = new T[size * 2];
                if(head < tail)
                {
                    for(int i =0; i < (tail - head) + 1; i++)
                    {
                        tempList[i] = list[ tail - (head) +i];
                    }
                    
                    tail = tail - head;
                    head = 0;
                }
                else
                {
                    int totalItem = (size - head) + tail + 1;
                    int arrIndex = 0;
                    //Copy all the items from Head to End of the list
                    for(int i =head; i < size -1; i++)
                    {
                        tempList[arrIndex] = list[i];
                        arrIndex++;
                    }

                    //Copy all the items from 0 to Tail
                    for(int i =0; i <= tail; i++)
                    {
                        tempList[arrIndex] = list[i];
                        arrIndex++;
                    }


                    list = tempList;
                    head = 0;
                    tail = size-1;
                }
            }
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
