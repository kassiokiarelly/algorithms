using System;

namespace Algorithms.DataStructures
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public BinaryTree()
        {

        }

        public BinaryTreeNode<T> Root { get; private set; }

        private void Add(BinaryTreeNode<T> root, BinaryTreeNode<T> node)
        {
            if (root == null)
            {
                Root = node;
            }
            else
            {

                if (node.Key.CompareTo(root.Key) < 0)
                {
                    if (root.Left == null)
                    {
                        root.Left = node;
                    }
                    else
                    {
                        Add(root.Left, node);
                    }
                }

                if (node.Key.CompareTo(root.Key) >= 0)
                {
                    if (root.Right == null)
                    {
                        root.Right = node;
                    }
                    else
                    {
                        Add(root.Right, node);
                    }
                }

            }

        }

        public void Print()
        {
            Print(Root);
        }

        public void Add(T key)
        {
            var node = new BinaryTreeNode<T>(key);
            Add(Root, node);
        }

        public BinaryTreeNode<T> Find(T key)
        {
            return Find(Root, key);
        }

        private BinaryTreeNode<T> Find(BinaryTreeNode<T> root, T key)
        {
            if (root != null)
            {
                var compare = key.CompareTo(root.Key);
                if (compare == 0)
                {
                    return root;
                }
                else if (compare < 0)
                {
                    return Find(root.Left, key);
                }
                else
                {
                    return Find(root.Right, key);
                }
            }
            return null;
        }

        private void Print(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                Print(node.Left);
                Console.WriteLine(node);
                Print(node.Right);
            }

        }

    }
}
