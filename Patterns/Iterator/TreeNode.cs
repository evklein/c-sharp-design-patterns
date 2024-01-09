namespace c_sharp_design_patterns.Patterns.Iterator;

internal class TreeNode : IIterableCollection<TreeNode>
{
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }
    public string Value { get; set; }

    public IIterator<TreeNode> CreateIterator()
    {
        return new TreeDFSIterator(this);
    }

    public IIterator<TreeNode> CreateItertor(string condition)
    {
        return condition switch
        {
            "DFS" => new TreeDFSIterator(this),
            "BFS" => new TreeBFSIterator(this),
            _ => throw new ArgumentException("Invalid condition")
        };
    }
}
