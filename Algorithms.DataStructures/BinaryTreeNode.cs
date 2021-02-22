using System;

namespace Algorithms.DataStructures
{
    public class BinaryTreeNode<T> where T : IComparable<T>
    {
        public BinaryTreeNode(T key)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key), "Null key");

            Key = key;
        }

        public T Key { get; internal set; }

        public BinaryTreeNode<T> Root { get; private set; }

        private BinaryTreeNode<T> left;
        public BinaryTreeNode<T> Left
        {
            get { return left; }
            set
            {
                left = value;
                value.Root = this;
            }
        }


        private BinaryTreeNode<T> right;
        public BinaryTreeNode<T> Right
        {
            get { return right; }
            set
            {
                right = value;
                value.Root = this;
            }
        }

        public override string ToString()
        {            
            return $"{Key}";
        }

    }
}
