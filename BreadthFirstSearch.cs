

using static System.Runtime.InteropServices.JavaScript.JSType;

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

    // bfs a 2d array
    // https://leetcode.com/problems/sliding-puzzle/description/
    // On an 2 x 3 board, there are five tiles labeled from 1 to 5, and an empty square represented by 0. A move consists of choosing 0 and a 4-directionally adjacent number and swapping it.
    // The state of the board is solved if and only if the board is [[1,2,3],[4,5,0]].
    // Given the puzzle board board, return the least number of moves required so that the state of the board is solved.If it is impossible for the state of the board to be solved, return -1.
    //public int SlidingPuzzle(int[][] board)
    //{
    //    var reponse = -1;

    //}

}

