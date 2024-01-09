namespace c_sharp_design_patterns.Patterns.Iterator;

internal class TreeDFSIterator : IIterator<TreeNode>
{
    public TreeNode Root { get; init; }

    private Stack<TreeNode> _stackOfTreeNodes;
    private TreeNode? _currentNode;

    public TreeDFSIterator(TreeNode root)
    {
        Root = root;

        _stackOfTreeNodes = new Stack<TreeNode>();
        _currentNode = Root;

        generateStack();
    }


    public TreeNode GetNext()
    {
        if (!HasMore())
        {
            throw new InvalidOperationException("No more elements");
        }

        TreeNode nextNode = _stackOfTreeNodes.Pop();
        _currentNode = nextNode.Right;
        generateStack();

        return nextNode;
    }

    public bool HasMore()
    {
        return _stackOfTreeNodes.Any();
    }

    private void generateStack()
    {
        while (_currentNode is not null)
        {
            _stackOfTreeNodes.Push(_currentNode);
            _currentNode = _currentNode.Left;
        }
    }
}
