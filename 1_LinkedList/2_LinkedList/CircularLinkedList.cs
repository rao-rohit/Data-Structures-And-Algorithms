using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LinkedList._2_LinkedList
{

    //Class to represent a Circular Linked List : The tail node points to the Head Node
    /// <summary>
    /// 
            /*  40 -> 30 -> 20 - > 10
             *   ^                  |
             *   |__________________|        Head = 40, Tail = 10
             */

    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CircularLinkedList<T> : ICollection<T>
    {
        //Head Node of List
        public CircularLinkedListNode<T> Head;

        //Tail Node of List
        public CircularLinkedListNode<T> Tail;

        //Counter for number of items in List
        public int Count;

        #region ICollection Properties

        //ICollection Count
        int ICollection<T>.Count
        {
            get
            {
                return Count;
            }
        }

        //ICollection ReadOnly
        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Add

        /// <summary>
        /// Method to add Head Node in list
        /// </summary>
        /// <param name="item">Node Object containing Value</param>
        public void AddFirst(CircularLinkedListNode<T> item)
        {
            if(Count ==0)
            {
                Head = Tail = item;
            }
            else
            {
                CircularLinkedListNode<T> tempHead = Head;
                item.Next = Head;
                Head = item;
            }

            Tail.Next = Head;
            Count++;
        }

        /// <summary>
        /// Method to add Tail Node in list
        /// </summary>
        /// <param name="item">Node Object containing Value</param>
        public void AddLast(CircularLinkedListNode<T> item)
        {
            if(Count ==0)
            {
                AddFirst(item);
            }
            else
            {
                Tail.Next = item;
                Tail = item;
                Tail.Next = Head;
                Count++;                
            }
        }
        
        // ICollection Add :
        /// <summary>
        /// Implementation of ICollection ADD method. We are calling the AddFirst method
        /// </summary>
        /// <param name="item">Value of a Node</param>
        public void Add(T item)
        {
            AddFirst(new CircularLinkedListNode<T>(item));
        }

        #endregion

        #region Remove

        /// <summary>
        /// Remove Head node from the List and make next node as Head
        /// </summary>
        public void RemoveFirst()
        {
            if(Count > 0)
            {
                if(Count == 1)
                {
                    Clear();
                }
                else
                {
                    Head = Head.Next;
                    Tail.Next = Head;
                    Count--;
                }
            }
        }

        /// <summary>
        /// Remove Tail node from the List and make previous node as Tail
        /// </summary>
        public void RemoveLast()
        {
            if(Count>0)
            {
                if (Count == 1)
                    Clear();
                else
                {
                    CircularLinkedListNode<T> current = Head;

                    while(current.Next != Tail)
                    {
                        current = current.Next;
                    }

                    current.Next = Head;
                    Tail = current;
                    Count--;
                }
                

            }

        }

        //ICollection Remove
        /// <summary>
        /// Implementation of ICollection Remove Method.
        /// Remove the node from the list if value matches (first occurrence)
        /// </summary>
        /// <param name="item">Value of node to delete</param>
        /// <returns></returns>
        public bool Remove(T item)
        {
            if (Count > 0)
            {
                if (Head.Value.Equals(item))
                {
                    RemoveFirst();
                    return true;
                }
                else
                {
                    CircularLinkedListNode<T> current = Head;
                    while (current.Next != Head)
                    {
                        if (current.Next.Value.Equals(item))
                        {
                          
                            if (current.Next == Tail)
                                Tail = current;
                            else
                                current.Next = current.Next.Next;

                            Count--;
                            return true;
                        }

                        current = current.Next;

                    }
                }


            }
            return false;
        }



        #endregion

        #region Clear

        //ICollection Clear
        /// <summary>
        /// Implementation of ICollection Clear method
        /// Clear the Circular Linked List
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        #endregion

        #region Contains
        //ICollection Contains
        /// <summary>
        /// Implementation of Icollection Contains method
        /// Return true of list contains the item specified in "item" parameter
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            if(Count > 0)
            {
                if (Head.Value.Equals(item) || Tail.Value.Equals(item))
                    return true;
                else
                {
                    CircularLinkedListNode<T> current = Head.Next;
                    while(current != Tail)
                    {
                        if (current.Value.Equals(item))
                            return true;
                    }
                }
            }
            return false;
        }

        #endregion

        #region Icollection : Not Implemented 
        //ICollection : Not Implemented
        public void CopyTo(T[] array, int arrayIndex)
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

        #endregion
    }
}
