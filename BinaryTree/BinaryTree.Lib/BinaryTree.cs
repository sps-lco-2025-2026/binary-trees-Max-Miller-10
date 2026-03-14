using System.Numerics;

namespace BinaryTree.Lib
{

    public class BinaryTree<T> where T: IComparable<T>
    {
        Node<T>? root;

        public BinaryTree()
        {
        }

        public BinaryTree(T val)
        {
           root = new Node<T>(val);
        }

        public void Insert(T val)
        {
            if (root == null) root = new Node<T>(val);
            else root.Insert(val);
        }

        public override string ToString()
        {
            return root?.ToString() ?? "";
        }

        public bool Contains (T val)
        {
            return root?.Contains(val) ?? false;
        }

        public bool Duplicates()
        {
            return root?.Duplicates() ?? false;
        }

        public int Depth
        {
            get
            {
                return root?.Depth ?? 0;
            }
        }

        public bool IsBalanced
        {
            get
            {
                return root?.IsBalanced ?? true;
            }
        }

    }
}
