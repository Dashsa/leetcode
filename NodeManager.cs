using System.Security.Cryptography.X509Certificates;

public class NodeManager
{
    public class TreeNode
    {
        public int val;

        public TreeNode? left;

        public TreeNode? right;

        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    private TreeNode _testTree1;
    private TreeNode _testTree2;
    private TreeNode _testTree3;

    public NodeManager()
    {

        // _testTree1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        _testTree1 = new TreeNode(1);
        _testTree1.left = new TreeNode(2);
        _testTree1.right = new TreeNode(3);

        _testTree2 = new TreeNode(10);
        _testTree2.left = new TreeNode(8).left = new TreeNode(6);
        _testTree2.right = new TreeNode(3);



        _testTree3 = new TreeNode(1, new TreeNode(2).left = new TreeNode(4), new TreeNode(3));
    }

    public bool TestTrees()
    {
        var foo = _testTree1;
        var moo = _testTree2;
        var doo = _testTree3;
        return true;
    }

}