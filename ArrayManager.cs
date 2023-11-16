public class ArrayManager
{
    public void Works()
    {
        Console.WriteLine("Array Manager");
    }

    public void ArrayUtil()
    {
        var myArray = new int[] { 1, 2, 3, 4, 5, 6, };

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }
    }

    // https://leetcode.com/problems/number-of-good-pairs/
    // works.
    public int NumIdenticalPairs(int[] nums)
    {
        var result = 0;
        for (var i = 0; i <= nums.Length - 1; i++)
        {
            for (var j = i + 1; j <= nums.Length - 1; j++)
            {
                if (nums[i] == nums[j] && i < j)
                {
                    result++;
                }
            }
        }

        return result;
    }
}