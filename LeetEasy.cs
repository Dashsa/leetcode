public class LeetEasy
{
    public void Works()
    {
        Console.WriteLine("leet easy");
    }

    public bool ContainsDuplicate(int[] nums)
    {
        var result = false;
        var dict = new Dictionary<int, int>();

        foreach (var i in nums)
        {
            if (dict.ContainsKey(i))
            {
                result = true;
                return result;
            }
            else
            {
                dict.Add(i, 1);
            }
        }
        return result;
    }

    //https://leetcode.com/problems/contains-duplicate-ii/
    // Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that 
    // nums[i] == nums[j] and abs(i - j) <= k.
    // Input: nums = [1,2,3,1], k = 3 =====> Output: true
    // This works but is too slow, need to optimize - mayby dict, or sliding window??
    // public bool ContainsNearbyDuplicate(int[] nums, int k)
    // {
    //     var result = false;

    //     for (var i = 0; i <= nums.Length -1; i++)
    //     {
    //         for (var j = i + 1; j <= nums.Length -1; j++)
    //         {
    //             if (nums[i] == nums[j])
    //             {
    //                 if (Math.Abs(i - j) <= k)
    //                 {
    //                     return true;
    //                 }
    //             }
    //         }
    //     }


    //     return result;
    // }
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var result = false;
        var lp = 0;
        var rp = 1;

        foreach (var i in nums)
        {
            while (lp <= nums.Length - 1 && rp <= nums.Length - 1)
            {
                if (nums[lp] == nums[rp])
                {
                    if (Math.Abs(lp - rp) <= k)
                    {
                        return true;
                    }
                    else
                    {
                        lp = rp;
                        rp++;
                    }

                }
                else
                {
                    rp++;
                }
            }
        }
        return result;
    }

    //https://leetcode.com/problems/buy-two-chocolates/
    // Input: prices = [1,2,2], money = 3
    // Output: 0
    // Explanation: Purchase the chocolates priced at 1 and 2 units respectively. You will have 3 - 3 = 0 units of money afterwards. Thus, we return 0.
    public int BuyChoco(int[] prices, int money)
    {
        var firstMin = int.MaxValue;
        var secondMin = int.MaxValue;
        foreach (var i in prices)
        {
            if (i < firstMin)
            {
                secondMin = firstMin;
                firstMin = i;
            }
            else if (i < secondMin)
            {
                secondMin = i;
            }
        }
        var runningTotal = money - (firstMin + secondMin);
        return runningTotal >= 0 ? runningTotal : money;
    }
}