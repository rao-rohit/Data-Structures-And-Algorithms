using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4_BinaryTree;


namespace _4_BinaryTree_Test
{
    [TestClass]
    public class UnitTestBinaryTree
    {
        [TestMethod]
        public void Add()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Add(100);      // Root
            tree.Add(90);       // Root.Left
            tree.Add(80);       //Root.Right

            tree.Add(70);       //Root.Left.Left = 100 -> 90 -> 70
            tree.Add(60);       //Root.Left.Right = 100 -> 90 -> 60

            tree.Add(50);       //Root.Right.Left = 100 -> 80 -> 50
            tree.Add(40);       //Root.Right.Right = 100 -> 80 -> 40

            tree.Add(30);       //Root.Left.Left.Left = 100 -> 90 -> 70 -> 30
            tree.Add(20);       //Root.Left.Left.Right = 100 -> 90 -> 70 -> 20
            tree.Add(10);       //Root.Left.Right.Left = 100 -> 90 -> 60 -> 10
            tree.Add(5);       //Root.Left.Right.Right = 100 -> 90 -> 60 -> 5


            //                100
            //               /   \
            //              /     \
            //             /       \
            //            90       80
            //           / \       / \
            //          /   \     /   \
            //         70   60   50   40
            //        / \   / \
            //       30 20 10  5
            //       




            Assert.AreEqual(tree.Root.Value, 100);
            Assert.AreEqual(tree.Root.Left.Value, 90);
            Assert.AreEqual(tree.Root.Right.Value, 80);

            Assert.AreEqual(tree.Root.Left.Left.Value, 70);
            Assert.AreEqual(tree.Root.Left.Right.Value, 60);

            Assert.AreEqual(tree.Root.Right.Left.Value, 50);
            Assert.AreEqual(tree.Root.Right.Right.Value, 40);

            Assert.AreEqual(tree.Root.Left.Left.Left.Value, 30);
            Assert.AreEqual(tree.Root.Left.Left.Right.Value, 20);

            Assert.AreEqual(tree.Root.Left.Right.Left.Value, 10);
            Assert.AreEqual(tree.Root.Left.Right.Right.Value, 5);


        }
    }
}
