using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3_Queue;

namespace _3_Queue_Test.Queue_LinkedList
{
    [TestClass]
   public class UnitTestQueueLinkedList
    {

        [TestMethod]
        public void Enqueue()
        {
            QueueUsingLinkedList<int> queue = new QueueUsingLinkedList<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            //10 <- 20 <- 30 <- 40


            Assert.AreEqual(queue.Count, 4);

        }

        [TestMethod]
        public void Dequeue()
        {
            QueueUsingLinkedList<int> queue = new QueueUsingLinkedList<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            //10 <- 20 <- 30 <- 40

            queue.Dequeue();
            queue.Dequeue();

            //30 <- 40


            Assert.AreEqual(queue.Count, 2);

        }

        [TestMethod]
        public void Peek()
        {
            QueueUsingLinkedList<int> queue = new QueueUsingLinkedList<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            //10 <- 20 <- 30 <- 40

            queue.Dequeue();
            queue.Dequeue();

            //30 <- 40


            Assert.AreEqual(queue.Peek(), 30);
        }

        [TestMethod]
        public void Clear()
        {
            QueueUsingLinkedList<int> queue = new QueueUsingLinkedList<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            //10 <- 20 <- 30 <- 40

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

          
            Assert.AreEqual(queue.Count(), 0);
        }
    }
}
