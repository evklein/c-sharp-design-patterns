namespace c_sharp_design_patterns.Patterns.Iterator;

internal class TreeBFSIterator : IIterator<TreeNode>
{
    public TreeNode Root { get; init; }

    private Queue<TreeNode> _nodeQueue;
    private TreeNode? _currentNode;

    public TreeBFSIterator(TreeNode root)
    {
        Root = root;

        _nodeQueue = new Queue<TreeNode>();
        _nodeQueue.Enqueue(Root);
    }


    public TreeNode GetNext()
    {
        TreeNode next = _nodeQueue.Dequeue();
        
        if (next.Left is not null)
        {
            _nodeQueue.Enqueue(next.Left);
        }
        if (next.Right is not null)
        {
            _nodeQueue.Enqueue(next.Right);
        }

        return next;
    }

    public bool HasMore()
    {
        return _nodeQueue.Any();
    }
}
