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
    // Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. 
    // The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 1){
            if(nums[0] == val){
                return 0;
            }else{
                nums[0] = val;
                return 1;
            }
        }
            

        
        var counter = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[counter] = nums[i];
                counter++;
            }
            
        }
        return counter;
    }

    public List<int> TwoSum(int[] input, int target)
    {
        // this holds the indexes of the inputs that add up to the target.
        var resultIndex = new List<int>();

        // key = index, value = value
        var sumDict = new Dictionary<int, int>();

        for (var i = 0; i < input.Length; i++)
        {

            if (sumDict.ContainsValue(target - input[i]))
            {
                var index = sumDict.Where(c => c.Value == target - input[i]).FirstOrDefault();
                resultIndex.Add(index.Key);
                resultIndex.Add(i);
            }
            else
            {
                sumDict.Add(i, input[i]);
            }
        }
        return resultIndex;
    }

    // https://leetcode.com/problems/plus-one/
    //[9] >>[1, 0]. [1, 3, 2] >> [1, 3, 3]
    public int[] PlusOne(int[] digits)
    {
        var last = digits.Length - 1;



        for (var i = last; i >= 0; i--)
        {

        }
        return digits;
    }

    // https://leetcode.com/problems/find-words-containing-character/
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        var result = new List<int>();
        var counter = 0;
        foreach (var word in words)
        {
            foreach (char letter in word)
            {
                if (letter == x)
                {
                    result.Add(counter);
                    break;
                }
            }
            counter++;
        }
        return result;
    }

    // https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    public int RemoveDuplicates(int[] nums)
    {

        if (nums.Length == 0)
            return 0;

        var result = 1;
        var leftPointer = 0;
        var rightPointer = 1;

        while (leftPointer <= nums.Length - 1 && rightPointer <= nums.Length - 1)
        {
            if (nums[leftPointer] == nums[rightPointer])
            {
                rightPointer++;
            }
            else
            {
                nums[leftPointer + 1] = nums[rightPointer];
                leftPointer++;
                result++;
            }
        }

        return result;
    }
}