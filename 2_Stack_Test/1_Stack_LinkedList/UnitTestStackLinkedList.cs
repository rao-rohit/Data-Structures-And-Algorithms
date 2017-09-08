using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2_Stack;

namespace _2_Stack_Test._1_Stack_LinkedList
{
    [TestClass]
   public class UnitTestStackLinkedList
    {

        /// <summary>
        /// Insert an element on top of the stack.
        /// </summary>
        [TestMethod]
        public void Push()
        {
            StackUsingLinkedList<int> stack = new StackUsingLinkedList<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            /*
              40    --- Top
              30
              20
              10
            */

            Assert.AreEqual(stack.Peek(), 40);
            Assert.AreEqual(stack.Count(), 4);

        }

        /// <summary>
        /// Remove the top element from stack. It will return the removed item.
        /// </summary>

        [TestMethod]
        public void Pop()
        {
            StackUsingLinkedList<int> stack = new StackUsingLinkedList<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            /*
              40    --- Top
              30
              20
              10
            */

            Assert.AreEqual(stack.Pop(), 40);
            Assert.AreEqual(stack.Count(), 3);
        }

        /// <summary>
        /// Get the top element from stack.
        /// </summary>
        [TestMethod]
        public void Peek()
        {
            StackUsingLinkedList<int> stack = new StackUsingLinkedList<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            /*
              40    --- Top
              30
              20
              10
            */
            stack.Pop();
            stack.Pop();

            Assert.AreEqual(stack.Peek(), 20);
         
        }

        [TestMethod]
        public void Clear()
        {
            StackUsingLinkedList<int> stack = new StackUsingLinkedList<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            /*
              40    --- Top
              30
              20
              10
            */

            stack.Clear();
            Assert.AreEqual(stack.Count(), 0);
        }

        [TestMethod]
        public void Count()
        {
            StackUsingLinkedList<int> stack = new StackUsingLinkedList<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            /*
              40    --- Top
              30
              20
              10
            */

            stack.Clear();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);


            /*
              30   --- Top
              20
              10
            */

            Assert.AreEqual(stack.Count(), 3);
        }

    }
}
