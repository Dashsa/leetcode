
/// <summary>
/// Two D arrays aka Matrix are used to store data in a grid format.
/// Its basically and array of arrays.
/// Each internal array tends to be the same size.
/// [
/// [1,2,3],
/// [4,5,6],
/// ]
/// 
/// To access data, use a row, column index.
/// so to access 5, you would use [1][1].
/// 
/// Traversal is simialr to binary trees.
/// typically start at top left ([0][0])and move to bottom right.
/// </summary>


public class TwoDArrayManager
{

    public void test2D()
    {
        var my2DArray = new int[,]{
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        // loop and print.
        for (int i = 0; i < my2DArray.GetLength(0); i++)
        {
            for (int j = 0; j < my2DArray.GetLength(1); j++)
            {
                Console.WriteLine(my2DArray[i, j]);
            }
        }

    }

}