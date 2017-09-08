using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1_LinkedList._2_LinkedList;

namespace _1_LinkedList_Test._4_CircularLinkedList
{
    [TestClass]
    public class UnitTestCircular
    {
        [TestMethod]
        public void AddFirst()
        {
            CircularLinkedList<int> cll = new CircularLinkedList<int>();
            cll.AddFirst(new CircularLinkedListNode<int>(10));
            cll.AddFirst(new CircularLinkedListNode<int>(20));
            cll.AddFirst(new CircularLinkedListNode<int>(30));
            cll.AddFirst(new CircularLinkedListNode<int>(40));

            /*  40 -> 30 -> 20 - > 10
             *   ^                  |
             *   |__________________|        Head = 40, Tail = 10
             */

            Assert.AreEqual(cll.Head.Value, 40);
            Assert.AreEqual(cll.Tail.Value, 10);
            Assert.AreEqual(cll.Tail.Next.Value, 40);

        }

        [TestMethod]
        public void AddLast()
        {
            CircularLinkedList<int> cll = new CircularLinkedList<int>();
            cll.AddLast(new CircularLinkedListNode<int>(10));
            cll.AddLast(new CircularLinkedListNode<int>(20));
            cll.AddLast(new CircularLinkedListNode<int>(30));
            cll.AddLast(new CircularLinkedListNode<int>(40));

            /*  10 -> 20 -> 30 - > 40
             *   ^                  |
             *   |__________________|        Head = 10, Tail = 40
             */

            Assert.AreEqual(cll.Head.Value, 10);
            Assert.AreEqual(cll.Tail.Value, 40);
            Assert.AreEqual(cll.Tail.Next.Value, 10);

        }

        [TestMethod]
        public void RemoveFirst()
        {
            CircularLinkedList<int> cll = new CircularLinkedList<int>();
            cll.Add((10));
            cll.Add((20));
            cll.Add((30));
            cll.Add((40));

             /*  40 -> 30 -> 20 - > 10
             *   ^                  |
             *   |__________________|        Head = 40, Tail = 10
             */

            cll.RemoveFirst();

            /*  30 -> 20 - > 10
             *   ^            |
             *   |____________|        Head = 40, Tail = 10
             */

            Assert.AreEqual(cll.Head.Value, 30);
            Assert.AreEqual(cll.Tail.Value, 10);
            Assert.AreEqual(cll.Tail.Next.Value, 30);

        }

        [TestMethod]
        public void RemoveFirstandMakeEmpty()
        {
            CircularLinkedList<int> cll = new CircularLinkedList<int>();
            cll.Add((10));
            cll.Add((20));
          

            /*  20 - > 10
            *   ^       |
            *   |_______|        Head = 20, Tail = 10
            */

            cll.RemoveFirst();
            cll.RemoveFirst();

            /* 
             *   NULL & Count should be 0
             *   
             */

            Assert.AreEqual(cll.Head, null);
            Assert.AreEqual(cll.Count, 0);
           

        }

        [TestMethod]
        public void RemoveLast()
        {
            CircularLinkedList<int> cll = new CircularLinkedList<int>();
            cll.Add((10));
            cll.Add((20));
            cll.Add((30));
            cll.Add((40));

            /*  40 -> 30 -> 20 - > 10
            *   ^                  |
            *   |__________________|        Head = 40, Tail = 10
            */

            cll.RemoveLast();
            cll.RemoveLast();

            /*  40 -> 30 
             *   ^    |
             *   |____|        Head = 40, Tail = 30
             */

            Assert.AreEqual(cll.Head.Value, 40);
            Assert.AreEqual(cll.Tail.Value, 30);
            Assert.AreEqual(cll.Tail.Next.Value, 40);
        }

        [TestMethod]
        public void RemoveLastAndEmptyList()
        {
            CircularLinkedList<int> cll = new CircularLinkedList<int>();
            cll.Add((10));
            cll.Add((20));
            cll.Add((30));
            cll.Add((40));

            /*  40 -> 30 -> 20 - > 10
            *   ^                  |
            *   |__________________|        Head = 40, Tail = 10
            */

            cll.RemoveLast();
            cll.RemoveLast();
            cll.RemoveLast();
            cll.RemoveLast();

            /*  
             *  NULL, Count should be 0
             */

            Assert.AreEqual(cll.Head, null);
            Assert.AreEqual(cll.Count, 0);
            
        }

        [TestMethod]
        public void Remove()
        {
            CircularLinkedList<int> cll = new CircularLinkedList<int>();
            cll.Add((10));
            cll.Add((20));
            cll.Add((30));
            cll.Add((40));

            /*  40 -> 30 -> 20 - > 10
            *   ^                  |
            *   |__________________|        Head = 40, Tail = 10
            */

            cll.Remove(10);
            cll.Remove(20);
            cll.Remove(40);

            Assert.AreEqual(cll.Head.Value, 30);
            Assert.AreEqual(cll.Tail.Value, 30);
            Assert.AreEqual(cll.Tail.Next.Value, 30);
            Assert.AreEqual(cll.Count, 1);

        }
    }
}
