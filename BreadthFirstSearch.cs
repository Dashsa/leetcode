

public class BreadthFirstSearch
{

    public BreadthFirstSearch()
    {


    }
    /// Tree traversal algorithm.
    /// Start at the root node, and move left to right, level by level.
    public Node BFS(Node root, int key)
    {
        var queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            Console.WriteLine(current.Value);
            if (current.Value == key)
            {
                Console.WriteLine("Found it!");
                return current;
            }

            if (current.Left != null)
            {
                queue.Enqueue(current.Left);
            }

            if (current.Right != null)
            {
                queue.Enqueue(current.Right);
            }
        }

        return root;
    }

}

