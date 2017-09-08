using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LinkedList._2_LinkedList
{
    /// <summary>
    /// Class to represent a Singly LinkedList.
    /// Linked list should have 3 things :
    /// The HEAD node : Starting node
    /// The TAIL node : Ending node
    /// The Value of the Node
    /// </summary>
   public class LinkedList<T> : ICollection<T>
   {
        //Head Node of List
        public LinkedListNode<T> Head;

        //Tail Node of List
        public LinkedListNode<T> Tail;

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
                return false;
            }
        }

        #endregion

        #region Add

        /// <summary>
        /// Method to add Head Node in list
        /// </summary>
        /// <param name="item">Node Object containing Value</param>
        public void AddFirst(LinkedListNode<T> item)
        {
            //get the head node in temp node field
            LinkedListNode<T> tempHead = Head;

            //Set new node as Head
            Head = item;

            //Point rest of the nodes from new Head
            Head.Next = tempHead;

            Count++;

            //If Count == 1 then Head and Tail would be same
            if (Count == 1)
                Tail = Head;
        }

        //Original Add : Not Optimized
        //public void AddFirst(LinkedListNode<T> item)
        //{
        //    if (Head == null)
        //    {
        //        Head = item;
        //        Tail = Head; 
        //    }
        //    else
        //    {
        //        LinkedListNode<T> tempHead = Head;
        //        Head = item;
        //        Head.Next = tempHead;
        //    }

        //    Count++;

        //}

        /// <summary>
        /// Method to add Tail Node in list
        /// </summary>
        /// <param name="item">Node Object containing Value</param>
        public void AddLast(LinkedListNode<T> item)
        {
            if (Count == 0)
                Head = item;
            else
                Tail.Next = item;
            
            Tail = item;

            Count++;
            
        }


        // ICollection Add :
        /// <summary>
        /// Implementation of ICollection ADD method. We are calling the AddFirst method
        /// </summary>
        /// <param name="item">Value of a Node</param>
        public void Add(T item)
        {
            AddFirst(new LinkedListNode<T>(item));
        }


        
        public void Add(LinkedListNode<T> item)
        {
            if (Head == null)
            {
                Head = item;
            }
            else
            {
                if (Tail == null)
                    Head.Next = item;
                else
                    Tail.Next = item;

            }

            Tail = item;
        }
        #endregion

        #region Remove

        /// <summary>
        /// Remove Head node from the List and make next node as Head
        /// </summary>
        public void RemoveFirst()
        {
            if (Count > 0)
            {
                //Point Head to next node
                Head = Head.Next;
                Count--;

                if (Count == 0)
                   Tail = null;

              
            }
        }
        
        /// <summary>
        /// Remove Tail node from the List and make previous node as Tail
        /// </summary>
        public void RemoveLast()
        {
            if (Count > 0)
            {
                if (Count == 1)
                {
                    Head = Tail = null;
                }
                else
                {
                    LinkedListNode<T> current;
                    LinkedListNode<T> previous = new LinkedListNode<T>();
                    current = Head;
                    while (current.Next != Tail)
                    {
                        previous = current = current.Next;
                    }

                    current.Next = null;
                    Tail = current;
                }

                Count--;
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

            // 1. return false if list is empty
            // 2. check if the value equals to head node value
            // 3. check if value equal to middle or Tail node 

            if (Count != 0)
            {
                LinkedListNode<T> current = Head;

                //if value equals to Head node value
                if (current.Value.Equals(item))
                {
                    RemoveFirst();
                    return true;
                }

                else
                {
                    //Iterate all the nodes until we encountered Null in Next (i.e. tail node).
                    while (current.Next != null)
                    {
                        //Compare value of next to current node with parameneter value
                        if (current.Next.Value.Equals(item))
                        {
                            //Next node is tail node then change the tail node and its next pointer value
                            if (current.Next == Tail)
                            {
                                current.Next = null;
                                Tail = current;
                            }
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
        /// Clear the Doubly Linked List
        /// </summary>
        public void Clear()
        {
            Head = Tail = null;
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

            //1. Check in head / tail node for efficient result
            //2. check in remaining
            if(Count> 0)
            {
              
                if (Head.Value.Equals(item) || Tail.Value.Equals(item))
                {
                    return true;
                }
                else
                {
                    LinkedListNode<T> current = Head.Next;
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

        #region ICollection : Not Implemented Yet
        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }


        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = Head;
            while(current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
