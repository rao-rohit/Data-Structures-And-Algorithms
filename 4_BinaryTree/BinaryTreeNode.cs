using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_BinaryTree
{
   public class BinaryTreeNode<T>
   {
        public BinaryTreeNode<T> Left;
        public BinaryTreeNode<T> Right;
        public T Value;

        public BinaryTreeNode(T value)
        {
            Value = value;
        }
   }
}
