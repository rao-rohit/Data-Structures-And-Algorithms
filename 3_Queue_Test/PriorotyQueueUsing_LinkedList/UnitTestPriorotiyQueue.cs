using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3_Queue;


namespace _3_Queue_Test.PriorotyQueueUsing_LinkedList
{
    [TestClass]
    public class UnitTestPriorotiyQueue
    {

        [TestMethod]
        public void EnqueueDequeue()
        {
            PriorityQueueUsingLinkedList<int> queue = new PriorityQueueUsingLinkedList<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            //10 <- 20 <- 30 <- 40


            Assert.AreEqual(queue.Dequeue(), 40);


            queue.Enqueue(50);
            queue.Enqueue(60);

            Assert.AreEqual(queue.Dequeue(), 60);
            Assert.AreEqual(queue.Dequeue(), 50);
            Assert.AreEqual(queue.Dequeue(), 30);

            Assert.AreEqual(queue.Dequeue(), 20);
            Assert.AreEqual(queue.Dequeue(), 10);

        }

        [TestMethod]
        public void Dequeue()
        {
            PriorityQueueUsingLinkedList<int> queue = new PriorityQueueUsingLinkedList<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            //10 <- 20 <- 30 <- 40

            queue.Dequeue();
            queue.Dequeue();

            //30 <- 40


          

        }

    }
}
