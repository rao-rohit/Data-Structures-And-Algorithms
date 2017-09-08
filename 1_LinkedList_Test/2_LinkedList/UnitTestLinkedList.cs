using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_LinkedList._2_LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace _1_LinkedList_Test._2_LinkedList
{
    [TestClass]
    public class UnitTestLinkedList
    {
        /// <summary>
        /// Testing of Add first
        /// </summary>
        [TestMethod]
       
        public void AddFirst()
        {
            LinkedList<int> ll = new LinkedList<int>();

            //Add first node in empty and check if Head and Tail Points to same node
            //10 -> null
            ll.AddFirst(new LinkedListNode<int>(10));
            Assert.AreEqual(ll.Head.Value, 10);
            Assert.AreEqual(ll.Tail.Value, 10);


            //Add one more node and check value of head and Tail
            // 20 -> 10 - > null
            ll.AddFirst(new LinkedListNode<int>(20));
            Assert.AreEqual(ll.Head.Value, 20);
            Assert.AreEqual(ll.Tail.Value, 10);

            //Add one more node
            // 30 -> 20 -> 10
            ll.AddFirst(new LinkedListNode<int>(30));
            Assert.AreEqual(ll.Head.Value, 30);
            Assert.AreEqual(ll.Tail.Value, 10);

        }


        /// <summary>
        /// Testing of Add Last
        /// </summary>
        [TestMethod]
        public void AddLast()
        {
            LinkedList<int> ll = new LinkedList<int>();

            //Add first node in empty and check if Head and Tail Points to same node
            //10 -> null
            ll.AddLast(new LinkedListNode<int>(10));
            Assert.AreEqual(ll.Head.Value, 10);
            Assert.AreEqual(ll.Tail.Value, 10);


            //Add one more node and check value of head and Tail
            // 10 -> 20 - > null
            ll.AddLast(new LinkedListNode<int>(20));
            Assert.AreEqual(ll.Head.Value, 10);
            Assert.AreEqual(ll.Tail.Value, 20);

            //Add one more node
            // 10 -> 20 -> 30
            ll.AddLast(new LinkedListNode<int>(30));
            Assert.AreEqual(ll.Head.Value, 10);
            Assert.AreEqual(ll.Tail.Value, 30);
        }

        /// <summary>
        /// Testing of Add 
        /// </summary>
        [TestMethod]
        public void Add()
        {
          LinkedList<int> ll = new LinkedList<int>();

            ll.Add(new LinkedListNode<int>(10));
            ll.Add(new LinkedListNode<int>(20));
            ll.Add(new LinkedListNode<int>(30));

            Assert.AreEqual(ll.Head.Value, 10);
            Assert.AreEqual(ll.Tail.Value, 30);
            Assert.AreEqual(ll.Head.Next.Value, 20);



        }


        /// <summary>
        /// Testing of Remove First 
        /// </summary>
        [TestMethod]
        public void RemoveFirst()
        {
            LinkedList<int> ll = new LinkedList<int>();

            ll.AddFirst(new LinkedListNode<int>(10));
            ll.AddLast(new LinkedListNode<int>(20));
            ll.AddLast(new LinkedListNode<int>(30));
            ll.AddLast(new LinkedListNode<int>(40));
            ll.AddLast(new LinkedListNode<int>(50));

            //10 -> 20 -> 30 -> 40 -> 50
            Assert.AreEqual(ll.Head.Value, 10);
            Assert.AreEqual(ll.Tail.Value, 50);

            ll.RemoveFirst();
            //20 -> 30 -> 40 -> 50
            Assert.AreEqual(ll.Head.Value, 20);
            Assert.AreEqual(ll.Tail.Value, 50);

          

        }


        /// <summary>
        /// Testing of Remove Last 
        /// </summary>
        [TestMethod]

        public void RemoveLast()
        {
            LinkedList<int> ll = new LinkedList<int>();

            ll.AddFirst(new LinkedListNode<int>(10));
            ll.AddLast(new LinkedListNode<int>(20));
            ll.AddLast(new LinkedListNode<int>(30));
            ll.AddLast(new LinkedListNode<int>(40));
            ll.AddLast(new LinkedListNode<int>(50));

            //10 -> 20 -> 30 -> 40 -> 50
            Assert.AreEqual(ll.Head.Value, 10);
            Assert.AreEqual(ll.Tail.Value, 50);

            ll.RemoveFirst();
            //20 -> 30 -> 40 -> 50
            Assert.AreEqual(ll.Head.Value, 20);
            Assert.AreEqual(ll.Tail.Value, 50);


            ll.RemoveLast();
            //20 -> 30 -> 40
            Assert.AreEqual(ll.Head.Value, 20);
            Assert.AreEqual(ll.Tail.Value,40);
            Assert.AreEqual(ll.Count, 3);

        }


        /// <summary>
        /// Testing of Remove Any 
        /// </summary>
        [TestMethod]
        public void Remove()
        {
            LinkedList<int> ll = new LinkedList<int>();

            ll.Add(10);
            ll.AddLast(new LinkedListNode<int>(20));
            ll.AddLast(new LinkedListNode<int>(30));
            ll.AddLast(new LinkedListNode<int>(40));
            ll.AddLast(new LinkedListNode<int>(50));

            //10 -> 20 -> 30 -> 40 -> 50
            Assert.AreEqual(ll.Head.Value, 10);
            Assert.AreEqual(ll.Tail.Value, 50);

            ll.Remove(10);
            //20 -> 30 -> 40 -> 50
            Assert.AreEqual(ll.Head.Value, 20);
            Assert.AreEqual(ll.Tail.Value, 50);


            ll.Remove(50);
            //20 -> 30 -> 40
            Assert.AreEqual(ll.Head.Value, 20);
            Assert.AreEqual(ll.Tail.Value, 40);
            Assert.AreEqual(ll.Count, 3);

            ll.Remove(30);
            //20 ->  40
            Assert.AreEqual(ll.Head.Value, 20);
            Assert.AreEqual(ll.Tail.Value, 40);
            Assert.AreEqual(ll.Count, 2);
        }

        /// <summary>
        /// Testing of Contains
        /// </summary>
        [TestMethod]
        public void Contains()
        {
            LinkedList<int> ll = new LinkedList<int>();

            ll.Add(10);
            ll.AddLast(new LinkedListNode<int>(20));
            ll.AddLast(new LinkedListNode<int>(30));
            ll.AddLast(new LinkedListNode<int>(40));
            ll.AddLast(new LinkedListNode<int>(50));

            Assert.AreEqual(ll.Contains(20), true);
            Assert.AreEqual(ll.Contains(80), false);
           
        }

    }
}
