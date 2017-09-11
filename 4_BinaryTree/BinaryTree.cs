using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_BinaryTree
{

    /// <summary>
    /// Class to represent a binary tree.
    /// Each node can have maximum 2 child.
    /// </summary>
    /// <typeparam name="T"></typeparam>
   public class BinaryTree<T>
   {
        //It will hold the Root Node
        public BinaryTreeNode<T> Root;

        //It will hold the Iterating nodes
        private Queue<BinaryTreeNode<T>> IteratingNodesQueue;

        //Add Method to add node in a Binary Tree
        public void Add(T Item)
        {
            //Reset the iterating queue on each addition
            IteratingNodesQueue = new Queue<BinaryTreeNode<T>>();


            if (Root == null)
            {
                Root = new BinaryTreeNode<T>(Item);
               
            }
            else
                AddToTree(Item, Root);

        }

        //Recursive method : It will search for a place where we can add a node in a Binary tree.
        private void AddToTree(T item, BinaryTreeNode<T> root)
        {
            BinaryTreeNode<T> current = root;

            //Queue to store iterating nodes of tree
            if(!IteratingNodesQueue.Contains(root))
                IteratingNodesQueue.Enqueue(current);
       

            if(current.Left == null)
            {
                 current.Left = new BinaryTreeNode<T>(item);
                 return;
            }
            else
            {
                IteratingNodesQueue.Enqueue(current.Left);
            }

            if (current.Right == null)
            {
                current.Right = new BinaryTreeNode<T>(item);
                 return;
            }
            else
            {
                IteratingNodesQueue.Enqueue(current.Right);
            }

            //Remove the nodes which have both child
            IteratingNodesQueue.Dequeue();


            AddToTree(item, IteratingNodesQueue.First());
           
        }
   }
}
