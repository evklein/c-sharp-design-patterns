namespace c_sharp_design_patterns.Patterns.Iterator;

internal class IteratorDemo : IDemo
{
    public void Run()
    {
        // Initialize nodes
        TreeNode nodeA = new TreeNode() { Value = "A" };
        TreeNode nodeB = new TreeNode() { Value = "B" };
        TreeNode nodeC = new TreeNode() { Value = "C" };
        TreeNode nodeD = new TreeNode() { Value = "D" };
        TreeNode nodeE = new TreeNode() { Value = "E" };
        TreeNode nodeF = new TreeNode() { Value = "F" };

        // Arrange Tree
        nodeA.Left = nodeB;      //       A            
        nodeA.Right = nodeC;     //      / \
                                 //     B   C
        nodeB.Left = nodeD;      //    / \   \
        nodeB.Right = nodeE;     //   D   E   F

        nodeC.Right = nodeF;

        // Do Iterators
        IIterator<TreeNode> dfsIterator = nodeA.CreateItertor("DFS");
        while (dfsIterator.HasMore())
        {
            Console.WriteLine("DFS: " + dfsIterator.GetNext().Value);
        }

        Console.WriteLine(Environment.NewLine);
        
        IIterator<TreeNode> bfsIterator = nodeA.CreateItertor("BFS");
        while (bfsIterator.HasMore())
        {
            Console.WriteLine("BFS: " + bfsIterator.GetNext().Value);
        }
    }
}