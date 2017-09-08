using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1_LinkedList._1_Node;

namespace _1_LinkedList_Test._1_Node
{
    [TestClass]
    public class UnitTestNode
    {
        [TestMethod]
        public void TestAdd()
        {
            //first node 
            Node first = new Node() { Value = 10 };

            //second node
            Node second = new Node() { Value = 20 };

            //first node should point to second
            first.Next = second;

            //third node
            Node third = new Node() { Value = 30 };

            //second should point third
            second.Next = third;

            //check value of second node using next of first
            Assert.AreEqual(first.Next.Value, 20);

            //check value of third node
            Assert.AreEqual(third.Value, 30);

        }


    }
}
