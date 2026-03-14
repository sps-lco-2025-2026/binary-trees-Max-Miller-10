using BinaryTree.Lib;
namespace BinaryTree.Test
{


    [TestClass]
    public sealed class TestBinaryTree
    {
        [TestMethod]
        public void TestInsert()
        {
            BinaryTree<int> bt = new(7);
            bt.Insert(4);
            bt.Insert(18);
            bt.Insert(20);
            bt.Insert(19);
            bt.Insert(8);
            bt.Insert(5);
            Assert.AreEqual("4, 5, 7, 8, 18, 19, 20", bt.ToString());
        }

        [TestMethod]
        public void TestContains()
        {
            BinaryTree<int> bt = new(7);
            bt.Insert(4);
            bt.Insert(18);
            bt.Insert(20);
            bt.Insert(19);
            bt.Insert(8);
            bt.Insert(5);
            Assert.IsTrue(bt.Contains(18));
            Assert.IsTrue(bt.Contains(19));
            Assert.IsTrue(bt.Contains(5));
            Assert.IsFalse(bt.Contains(6));
        }

        [TestMethod]
        public void TestDuplicates()
        {
            BinaryTree<int> bt = new(7);
            bt.Insert(4);
            bt.Insert(18);
            bt.Insert(20);
            bt.Insert(19);
            bt.Insert(8);
            bt.Insert(5);
            Assert.IsFalse (bt.Duplicates());
            bt.Insert(19);
            Assert.IsTrue (bt.Duplicates());
        }

        [TestMethod] 
        public void TestDepth()
        {
            BinaryTree<int> bt = new(7);
            bt.Insert(4);
            bt.Insert(18);
            bt.Insert(20);
            bt.Insert(19);
            bt.Insert(8);
            bt.Insert(5);
            Assert.AreEqual(4, bt.Depth);
        }

        [TestMethod]
        public void TestBalanced()
        {
            BinaryTree<int> bt = new(4);
            bt.Insert(2);
            bt.Insert(5);
            bt.Insert(1);
            bt.Insert(3);
            bt.Insert(6);
            Assert.IsTrue(bt.IsBalanced);
            bt = new(1);
            bt.Insert(2);
            bt.Insert(5);
            bt.Insert(6);
            Assert.IsFalse(bt.IsBalanced);
        }
    }
}
