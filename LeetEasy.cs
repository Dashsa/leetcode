using System.Globalization;

public class LeetEasy
{
    public void Works()
    {
        Console.WriteLine("leet easy");
    }

    public bool ContainsDuplicate (int[] nums) {
        var result = false;
        var dict = new Dictionary<int, int> ();

        foreach (var i in nums) {
            if (dict.ContainsKey (i)) {
                result = true;
                return result;
            } else {
                dict.Add (i, 1);
            }
        }
        return result;
    }

    //https://leetcode.com/problems/contains-duplicate-ii/
    // Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the 
    // array such that 
    // nums[i] == nums[j] and abs(i - j) <= k.
    // Input: nums = [1,2,3,1], k = 3 =====> Output: true
    
    public bool ContainsNearbyDuplicate (int[] nums, int k) {
        var dict = new Dictionary<int, int> (); // make a dict to track.

        for (var i = 0; i <= nums.Length - 1; i++) { // loop through array/
            if (dict.ContainsKey (nums[i])) { // we have a match/
                if (Math.Abs (dict[nums[i]] - i) <= k) {// passes check
                    return true;
                }
                dict[nums[i]] = i; //u this means we failed the test, even though we had the correct index, so we update the last index of the element in the array.
            } else {
                dict.Add (nums[i], i);
            }
        }

        return false;
    }

   
    //https://leetcode.com/problems/buy-two-chocolates/
    // Input: prices = [1,2,2], money = 3
    // Output: 0
    // Explanation: Purchase the chocolates priced at 1 and 2 units respectively. You will have 3 - 3 = 0 units of money afterwards. Thus, we return 0.
    public int BuyChoco (int[] prices, int money) {
        var firstMin = int.MaxValue;
        var secondMin = int.MaxValue;
        foreach (var i in prices) {
            if (i < firstMin) {
                secondMin = firstMin;
                firstMin = i;
            } else if (i < secondMin) {
                secondMin = i;
            }
        }
        var runningTotal = money - (firstMin + secondMin);
        return runningTotal >= 0 ? runningTotal : money;
    }

    // https://leetcode.com/problems/score-of-a-string/
    // You are given a string s. The score of a string is defined as the sum of the absolute difference between the ASCII values of adjacent characters.
    // Return the score of s.

    // Input: s = "hello"==> Output: 13
    // The ASCII values of the characters in s are: 'h' = 104, 'e' = 101, 'l' = 108, 'o' = 111. 
    // So, the score of s would be |104 - 101| + |101 - 108| + |108 - 108| + |108 - 111| = 3 + 7 + 0 + 3 = 13.
    public int ScoreOfString(string s)
    {
        var result = 0;
        for (var i = 0; i <= s.Length - 1; i++)
        {
            if (i + 1 < s.Length)
            {
                result += Math.Abs((int)s[i] - (int)s[i + 1]);
            }
        }
        return result;
    }

    // // 1823. Find the Winner of the Circular Game
    //  public int FindTheWinner(int n, int k) {
    //     int[] friends = new int[n];
    //     int counter = 0;
    //     int pointer = 0;
    //     List<int> deadNums = new List<int>();

    //     for(int i = 0; i < n; i++)
    //     {
    //         friends[i] = i + 1;
    //     }

    //     while(deadNums.Count < n-1){
    //         for(var i = pointer; i < k; i ++){
                
    //         }

    //     }


    //     return 1;
    // }

}