//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace BinarySearchTree
//{
//    public struct BinarySearchTree<T> : IEnumerable<T>
//    {
//        public TreeNode<T> Value { get; set; }
//        public BinarySearchTree<T> NextNode { get; set; }

//        public BinarySearchTree(TreeNode<T> value)
//        {
//            this.Value = value;            
//        }

//        public BinarySearchTree(TreeNode<T> value, BinarySearchTree<T> nextNode )
//            :this(value)
//        {
//            this.NextNode = nextNode;
//        }
//        public IEnumerator GetEnumerator()
//        {
//            return this.GetEnumerator();
//        }

//        IEnumerator<T> IEnumerable<T>.GetEnumerator()
//        {
//            BinarySearchTree<T> next = this;
//            while (next.Value != null)
//            {
//                yield return next.Value;
//                next = next.NextNode;
//            }
//        }
//    }
//}
