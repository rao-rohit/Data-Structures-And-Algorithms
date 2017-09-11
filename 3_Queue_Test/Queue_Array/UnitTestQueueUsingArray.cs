using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3_Queue;

namespace _3_Queue_Test.Queue_Array
{
    [TestClass]
    public class UnitTestQueueUsingArray
    {

        [TestMethod]
        public void Enqueue()
        {
            QueueUsingArray<int> queue = new QueueUsingArray<int>();
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
            QueueUsingArray<int> queue = new QueueUsingArray<int>();
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
            QueueUsingArray<int> queue = new QueueUsingArray<int>();
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
            QueueUsingArray<int> queue = new QueueUsingArray<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            //10 <- 20 <- 30 <- 40

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();


            Assert.AreEqual(queue.Count, 0);
        }

    }
}
