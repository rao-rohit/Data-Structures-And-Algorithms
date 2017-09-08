using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LinkedList._2_LinkedList
{

            /*  10 <-> 20 <-> 30 - > 40
             * 
             * Head = 10, Tail = 40
             */

    
    /// <summary>
    /// Class to represent a Doubly Linked List : Each node points to previos and next node.
    /// Head only points to Next and Tail only points to Previous
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// 
    public class DoublyLinkedList<T> : ICollection<T>
    {
        //Head Node of List
        public DoublyLinkedListNode<T> Head { get; set; }

        //Tail Node of List
        public DoublyLinkedListNode<T> Tail { get; set; }

        //Counter for number of items in List
        public int Count = 0;

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
        public void AddFirst(DoublyLinkedListNode<T> item)
        {
            if(Count == 0)
            {
                Head = item;
                Head.Previous = null;
                Head.Next = null;
            }
            else
            {
                DoublyLinkedListNode<T> tempHead = Head;

                Head = item;
                Head.Next = tempHead;
                tempHead.Previous = Head;
                Head.Previous = null;
            }

            Count++;

            if (Count == 1)
                Tail = Head;
        }

        /// <summary>
        /// Method to add Tail Node in list
        /// </summary>
        /// <param name="item">Node Object containing Value</param>
        public void AddLast(DoublyLinkedListNode<T> item)
        {
            if(Count==0)
            {
                AddFirst(item);
            }
            else
            {
                Tail.Next = item;
                item.Previous = Tail;
                Tail = item;
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
            AddFirst(new DoublyLinkedListNode<T>(item));
        }

        #endregion

        #region Remove

        /// <summary>
        /// Remove Head node from the List and make next node as Head
        /// </summary>
        public void RemoveFirst()
        {
            if(Count>0)
            {
                if (Count == 1)
                    Clear();
                else
                {
                    Head = Head.Next;
                    Head.Previous = null;
                    Count--;
                }
               
            }
        }

        /// <summary>
        /// Remove Tail node from the List and make previous node as Tail
        /// </summary>
        public void RemoveLast()
        {
            if(Count > 0)
            {
                if (Count == 1)
                {
                    Clear();
                }
                else
                {

                    DoublyLinkedListNode<T> previousOfTail = Tail.Previous;
                    Tail.Previous = null;
                    previousOfTail.Next = null;
                    Tail = previousOfTail;
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
                    DoublyLinkedListNode<T> current = Head.Next;
                    while (current != null)
                    {
                        if (current.Value.Equals(item))
                        {
                            current.Previous.Next = current.Next;
                            if (current != Tail)
                                current.Next.Previous = current.Previous;
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
        /// Clear the Doubly Linked List
        /// </summary>
        public void Clear()
        {
            Tail.Previous = null;
            Head.Next = null;
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
            if (Count > 0)
            {
                if (Head.Value.Equals(item) || Tail.Value.Equals(item))
                    return true;
                else
                {
                    DoublyLinkedListNode<T> current = Head.Next;
                    while (current != Tail)
                    {
                        if (current.Value.Equals(item))
                            return true;
                        current = current.Next;
                    }
                }

            }
            return false;
        }



        #endregion

        #region Enumeration & Copy

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            DoublyLinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current;
                current = current.Next;

            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

      

        #endregion

     
   
    }
}
