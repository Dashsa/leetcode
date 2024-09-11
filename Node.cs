public class Node
{
    public int Value;

    public Node Left;

    public Node Right;

    public Node()
    {
    }

    public Node(int value)
    {
        Value = value;
    }

    public Node Insert(Node root, int value)
    {
        if (root == null)
        {
            return new Node(value);
        }

        if (value < root.Value)
        {
            root.Left = Insert(root.Left, value);
        }
        else
        {
            root.Right = Insert(root.Right, value);
        }

        return root;
    }

    public Node CreateExampleTree(Node root)
    {
        root = new Node(10);
        root.Insert(root, 1);
        root.Insert(root, 2);
        root.Insert(root, 3);
        root.Insert(root, 4);
        root.Insert(root, 5);
        root.Insert(root, 6);
        root.Insert(root, 7);
        root.Insert(root, 8);
        root.Insert(root, 9);
        root.Insert(root, 11);
        root.Insert(root, 12);
        root.Insert(root, 13);
        root.Insert(root, 14);
        root.Insert(root, 15);
        root.Insert(root, 16);
        root.Insert(root, 17);
        root.Insert(root, 18);
        root.Insert(root, 19);
        root.Insert(root, 20);

        return root;

    }

    public void PrintTree(Node root)
    {
        if (root == null)
        {
            return;
        }

        Console.WriteLine(root.Value);
        PrintTree(root.Left);
        PrintTree(root.Right);
    }


}