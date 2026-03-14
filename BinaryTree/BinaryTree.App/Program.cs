using BinaryTree.Lib;


BinaryTree<int> bt = new(7);
bt.Insert(4);
bt.Insert(18);
bt.Insert(20);
bt.Insert(19);
bt.Insert(8);
bt.Insert(5);

Console.WriteLine(bt.ToString());