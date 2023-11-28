public class AlgoManager
{

    public AlgoManager()
    {
    }

    /// <summary>
    /// Binary search is a divide and conquer search, only works on a sorted input.
    /// Average Time Complexity is O(log n)
    /// </summary>
    /// <param name="input"></param>
    /// <param name=""></param>
    /// <returns></returns>
    public bool BinarySearch(int[] input, int searchKey)
    {
        var isFound = false;
        var min = 0;
        var max = input.Length - 1;

        while (min <= max)
        {
            var midpoint = (min + max) / 2;

            if (searchKey == input[midpoint])
            {
                return true;
            }

            else if (searchKey < input[midpoint])
            {
                max = midpoint - 1;
            }

            else
            {
                min = midpoint + 1;
            }

        }

        return isFound;
    }


}