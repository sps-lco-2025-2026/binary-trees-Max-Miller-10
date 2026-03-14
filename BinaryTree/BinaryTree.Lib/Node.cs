namespace BinaryTree.Lib
{
    internal class Node<T> where T:IComparable<T>
    {
        T value_;
        Node<T>? leftSbtr_;
        Node<T>? rightSbtr_;

        internal Node(T val) => value_ = val;

        internal void Insert(T val)
        {
            if (val.CompareTo(value_) < 0)
            {
                if (leftSbtr_ == null) { leftSbtr_ = new Node<T>(val); }
                else { leftSbtr_.Insert(val); }
            }
            else
            {
                if (rightSbtr_ == null) { rightSbtr_ = new Node<T>(val); }
                else
                {
                    rightSbtr_.Insert(val);
                }
            }
        }

        public override string ToString()
        {
            string rightString = "";
            string leftString = "";
            if (leftSbtr_ != null) { leftString = leftSbtr_.ToString() + ", "; }
            if (rightSbtr_ != null) { rightString = ", " + rightSbtr_.ToString(); }
            return leftString + value_.ToString() + rightString;
        }

        internal bool Contains(T val)
        {
            int cmp = val.CompareTo(value_);
            if (cmp == 0) return true;
            if (cmp < 0) return leftSbtr_?.Contains(val) ?? false;
            return rightSbtr_?.Contains(val) ?? false;
        }

        internal bool Duplicates()
        {
            bool leftDuplicates = leftSbtr_ != null && (leftSbtr_.Contains(value_) || leftSbtr_.Duplicates());
            bool rightDuplicates = rightSbtr_ != null && (rightSbtr_.Contains(value_) || rightSbtr_.Duplicates());
            return leftDuplicates|| rightDuplicates;
        }

        internal int Depth
        {
            get
            {
                if (leftSbtr_ == null && rightSbtr_ == null) return 1;
                int leftLength = leftSbtr_?.Depth ?? 0;
                int rightLength = rightSbtr_?.Depth ?? 0;

                return 1 + Math.Max(leftLength, rightLength);
            }
        }

        internal bool IsBalanced
        {
            get
            {
                return Math.Abs((leftSbtr_?.Depth ?? 0) - (rightSbtr_?.Depth ?? 0)) <= 1 && (leftSbtr_?.IsBalanced ?? true) &&( rightSbtr_?.IsBalanced?? true);
            }
        }
    }
}
