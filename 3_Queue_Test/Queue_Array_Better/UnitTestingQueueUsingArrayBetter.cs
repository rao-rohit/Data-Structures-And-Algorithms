using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3_Queue;

namespace _3_Queue_Test.Queue_Array_Better
{
    [TestClass]
    public class UnitTestingQueueUsingArrayBetter
    {
        [TestMethod]
        public void Enqueue()
        {
            QueueUsingArrayBetter<int> queue = new QueueUsingArrayBetter<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            //10 <- 20 <- 30 <- 40


            Assert.AreEqual(queue.head, 0);
            Assert.AreEqual(queue.tail, 3);
            Assert.AreEqual(queue.Count, 4);


        }

        [TestMethod]
        public void Dequeue()
        {
            QueueUsingArrayBetter<int> queue = new QueueUsingArrayBetter<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            //10 <- 20 <- 30 <- 40

            queue.Dequeue();
            queue.Dequeue();

            //30 <- 40


            Assert.AreEqual(queue.head, 2);
            Assert.AreEqual(queue.tail, 3);
            Assert.AreEqual(queue.Count, 2);

        }

        [TestMethod]
        public void LoadTestMultiple()
        {
            QueueUsingArrayBetter<int> queue = new QueueUsingArrayBetter<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            //10 <- 20 <- 30 <- 40

            queue.Dequeue();
            queue.Dequeue();
            queue.Enqueue(50);
            queue.Enqueue(60);

            //30 <- 40


            Assert.AreEqual(queue.head, 2);
            Assert.AreEqual(queue.tail, 1);
            Assert.AreEqual(queue.Count, 4);

            queue.Dequeue();
            queue.Dequeue();

            Assert.AreEqual(queue.head, 0);
            Assert.AreEqual(queue.tail, 1);
            Assert.AreEqual(queue.Count, 2);

            queue.Dequeue();
            queue.Dequeue();

            Assert.AreEqual(queue.head,-1);
            Assert.AreEqual(queue.tail, -1);
            Assert.AreEqual(queue.Count, 0);

        }


    }
}
