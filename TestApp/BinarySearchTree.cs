using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    // Basic binary tree node
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    // Binary Search Tree implementation
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public TreeNode<T> Root { get; private set; }

        public void Insert(T value)
        {
            Root = Insert(Root, value);
        }

        private TreeNode<T> Insert(TreeNode<T> node, T value)
        {
            if (node == null)
                return new TreeNode<T>(value);

            int comparison = value.CompareTo(node.Value);
            if (comparison < 0)
                node.Left = Insert(node.Left, value);
            else
                node.Right = Insert(node.Right, value);

            return node;
        }

        // In-order traversal
        public void InOrderTraversal(Action<T> action)
        {
            InOrderTraversal(Root, action);
        }

        private void InOrderTraversal(TreeNode<T> node, Action<T> action)
        {
            if (node == null) return;

            InOrderTraversal(node.Left, action);
            action(node.Value);
            InOrderTraversal(node.Right, action);
        }
    }
}
