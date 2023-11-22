using System.Data.Common;
using System.Runtime.CompilerServices;

public class ArrayManager
{
    public void Works()
    {
        Console.WriteLine("Array Manager");
        var myArray = new string[] { "a", "b", "c" };

        myArray.Append("d");
        myArray.Prepend("ss");


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

    // https://leetcode.com/problems/remove-element/
    // Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.
    public int RemoveElement(int[] nums, int val)
    {
        var lastPlace = nums.Length - 1;
        var safeToUse = new Queue<int>(0);
        var counter = 0;
        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == val)
            {
                // we can replace, and make currentPlace
                if (nums[lastPlace] == val)
                {
                    safeToUse.Enqueue(i);
                }
                else // we need to keep this val
                {
                    nums[i] = nums[lastPlace];
                    lastPlace -= 1;
                }
            }
            else
            {
                counter++;
                if (safeToUse.Count > 0 && safeToUse.Peek() != i) // we only need to move if we are not at the same place.
                {
                    nums[safeToUse.Dequeue()] = nums[i];
                    nums[i] = val;
                    safeToUse.Enqueue(i);
                }
            }
        }

        return counter;
    }

}