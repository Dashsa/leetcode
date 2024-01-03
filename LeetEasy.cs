public class LeetEasy {
    public void Works () {
        Console.WriteLine ("leet easy");
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
}