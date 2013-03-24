using System;

namespace BinarySearchTree
{
    public class TreeNode<T>
    {
        public T Value { get; set; }

        public TreeNode(T value)
        {
            this.Value = value;
        }
    }
}
