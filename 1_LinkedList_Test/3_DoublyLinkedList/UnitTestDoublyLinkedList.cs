using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1_LinkedList._2_LinkedList;

namespace _1_LinkedList_Test._3_DoublyLinkedList
{
    [TestClass]
    public class UnitTestDoublyLinkedList
    {

        [TestMethod]
        public void AddFirst()
        {
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.AddFirst(new DoublyLinkedListNode<int>(10));
            dll.AddFirst(new DoublyLinkedListNode<int>(20));
            dll.AddFirst(new DoublyLinkedListNode<int>(30));

            //30 <-> 20 <-> 10   : Head 20, Tail 10
            Assert.AreEqual(dll.Head.Value, 30);
            Assert.AreEqual(dll.Head.Next.Value, 20);
            Assert.AreEqual(dll.Tail.Value, 10);
            Assert.AreEqual(dll.Tail.Previous.Value, 20);


        }   
        
        [TestMethod]
        public void AddLast()
        {
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.AddFirst(new DoublyLinkedListNode<int>(10));
            dll.AddLast(new DoublyLinkedListNode<int>(20));
            dll.AddLast(new DoublyLinkedListNode<int>(30));

            //10 <-> 30 <-> 20   : Head 10, Tail 30
            Assert.AreEqual(dll.Head.Value, 10);
            Assert.AreEqual(dll.Head.Next.Value, 20);
            Assert.AreEqual(dll.Tail.Value, 30);
            Assert.AreEqual(dll.Tail.Previous.Value, 20);

        }     

        [TestMethod]
        public void Add()
        {
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.Add(10);
            dll.Add(20);
            dll.Add(30);

            //30 <-> 20 <-> 10   : Head 20, Tail 10
            Assert.AreEqual(dll.Head.Value, 30);
            Assert.AreEqual(dll.Head.Next.Value, 20);
            Assert.AreEqual(dll.Tail.Value, 10);
            Assert.AreEqual(dll.Tail.Previous.Value, 20);
        }

        [TestMethod]
        public void RemoveFirst()
        {

            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.AddFirst(new DoublyLinkedListNode<int>(10));
            dll.AddFirst(new DoublyLinkedListNode<int>(20));
            dll.AddLast(new DoublyLinkedListNode<int>(30));
            dll.AddLast(new DoublyLinkedListNode<int>(40));

            //20 <-> 10 <-> 30 <-> 40   : Head 20, Tail 40

            dll.RemoveFirst(); // 10 <-> 30 <-> 40   : Head 10, Tail 40

            Assert.AreEqual(dll.Head.Value, 10);
            Assert.AreEqual(dll.Head.Next.Value, 30);
            Assert.AreEqual(dll.Tail.Value, 40);
            Assert.AreEqual(dll.Tail.Previous.Value, 30);
        }

        [TestMethod]
        public void RemoveFirstandMakeEmpty()
        {
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.AddFirst(new DoublyLinkedListNode<int>(10));
            dll.AddFirst(new DoublyLinkedListNode<int>(20));
           


            /*  20  <- > 10
            *                  Head = 20, Tail = 10
            */

            dll.RemoveFirst();
            dll.RemoveFirst();

            /* 
             *   NULL & Count should be 0
             *   
             */

            Assert.AreEqual(dll.Head, null);
            Assert.AreEqual(dll.Count, 0);


        }

        [TestMethod]
        public void RemoveLast()
        {
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.AddFirst(new DoublyLinkedListNode<int>(10));
            dll.AddFirst(new DoublyLinkedListNode<int>(20));
            dll.AddLast(new DoublyLinkedListNode<int>(30));
            dll.AddLast(new DoublyLinkedListNode<int>(40));

            //20 <-> 10 <-> 30 <-> 40   : Head 20, Tail 40

            dll.RemoveFirst(); // 10 <-> 30 <-> 40   : Head 10, Tail 40
            dll.RemoveLast(); // 10 <-> 30   : Head 10, Tail 30


            Assert.AreEqual(dll.Head.Value, 10);
            Assert.AreEqual(dll.Head.Next.Value, 30);
            Assert.AreEqual(dll.Tail.Value, 30);
            Assert.AreEqual(dll.Tail.Previous.Value, 10);
        }

        
        [TestMethod]
        public void RemoveLastAndEmptyList()
        {
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.Add((10));
            dll.Add((20));
            dll.Add((30));
            dll.Add((40));

            /*  40 -> 30 -> 20 - > 10
            *   ^                  |
            *   |__________________|        Head = 40, Tail = 10
            */

            dll.RemoveLast();
            dll.RemoveLast();
            dll.RemoveLast();
            dll.RemoveLast();

            /*  
             *  NULL, Count should be 0
             */

            Assert.AreEqual(dll.Head, null);
            Assert.AreEqual(dll.Count, 0);
            
        }

        [TestMethod]
        public void Remove()
        {
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.AddFirst(new DoublyLinkedListNode<int>(10));
            dll.AddFirst(new DoublyLinkedListNode<int>(20));
            dll.AddLast(new DoublyLinkedListNode<int>(30));
            dll.AddLast(new DoublyLinkedListNode<int>(40));

            //20 <-> 10 <-> 30 <-> 40   : Head 20, Tail 40

            dll.Remove(10); // 20 <-> 30 <-> 40   : Head 10, Tail 40
          
            Assert.AreEqual(dll.Head.Value, 20);
            Assert.AreEqual(dll.Head.Next.Value, 30);
            Assert.AreEqual(dll.Tail.Value, 40);
            Assert.AreEqual(dll.Tail.Previous.Value, 30);
        }

        [TestMethod]
        public void RemoveHeadTail()
        {
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.AddFirst(new DoublyLinkedListNode<int>(10));
            dll.AddFirst(new DoublyLinkedListNode<int>(20));
           

            //20 <-> 10  Head 20, Tail 10

            dll.Remove(10); // 20 <-> 30 <-> 40   : Head 10, Tail 40

            Assert.AreEqual(dll.Head.Value, 20);

            dll.Remove(20);

            Assert.AreEqual(dll.Count, 0);
        }

        [TestMethod]
        public void Contains()
        {

            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.AddFirst(new DoublyLinkedListNode<int>(10));
            dll.AddFirst(new DoublyLinkedListNode<int>(20));
            dll.AddLast(new DoublyLinkedListNode<int>(30));
            dll.AddLast(new DoublyLinkedListNode<int>(40));

            //20 <-> 10 <-> 30 <-> 40   : Head 20, Tail 40

            Assert.AreEqual(dll.Contains(10), true);
            Assert.AreEqual(dll.Contains(20), true);
            Assert.AreEqual(dll.Contains(30), true);
            Assert.AreEqual(dll.Contains(40), true);

            Assert.AreEqual(dll.Contains(100), false);

        }

        [TestMethod]
        public void Clear()
        {
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.AddFirst(new DoublyLinkedListNode<int>(10));
            dll.AddFirst(new DoublyLinkedListNode<int>(20));
            dll.AddLast(new DoublyLinkedListNode<int>(30));
            dll.AddLast(new DoublyLinkedListNode<int>(40));

            dll.Clear();

            Assert.AreEqual(dll.Count, 0);
        }

       
    }
}
