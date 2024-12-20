using System.Text;
using System.Text.RegularExpressions;

public class StringManager
{
    public void Works()
    {
        Console.WriteLine("String Manager.");
    }

    // https://leetcode.com/problems/goal-parser-interpretation/
    // You own a Goal Parser that can interpret a string command. The command consists of an alphabet of "G", "()" and/or "(al)" in some order. 
    // The Goal Parser will interpret "G" as the string "G", "()" as the string "o", and "(al)" as the string "al". 
    // The interpreted strings are then concatenated in the original order. Given the string command, return the Goal Parser's interpretation of command.

    // G -> G ... () -> o ... (al) -> al
    // PASSES
    public string Interpret(string command)
    {
        var sb = new StringBuilder();
        var len = command.Length;

        for (var i = 0; i < len; i++)
        {
            var currChar = command[i];
            if (currChar == 'G')
            {
                sb.Append(currChar);
                continue;
            }
            if (currChar == '(' && command[i + 1] == ')')
            {
                sb.Append('o');
                i++;
            }
            else
            {
                sb.Append('a');
                sb.Append('l');
                i += 3;
            }
        }

        return sb.ToString();
    }

    public string InterpretOptimal(string command)
    {
        return command.Replace("()", "o").Replace("(al)", "al");
    }

    // Udemy Section 5 String question. 
    // Typed out Strings. https://www.udemy.com/course/master-the-coding-interview-big-tech-faang-interviews/learn/lecture/19799318#overview

    public bool TypedOutString(string s1, string s2)
    {
        return FormatString(s1) == FormatString(s2);
    }

    /// <summary>
    /// This is using the TWO POINTER approach.
    /// We want to use two pointers to compare the chars in the different strings. We cant start at the left as the backspaces will cause troubles.
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    // public bool TypedOutStringOptimized(string s1, string s2)
    // {

    // }

    public void TwoPointer(string testStr)
    {
        var lp = 0;
        var rp = testStr.Length - 1;

        while (lp <= rp)
        {
            if (lp == rp)
            {
                Console.WriteLine($"lp {testStr[lp]}");
            }
            else
            {
                Console.WriteLine($"lp {testStr[lp]}, rp: {testStr[rp]}");
            }
            lp++;
            rp--;
        }


    }


    public int TwoPointerWeight(int targetWeight, List<int> listOfAvailableWeights)
    {
        var lp = 0;
        var rp = listOfAvailableWeights.Count() - 1;
        var response = 0;

        while (lp <= rp)
        {
            if (response == targetWeight)
            {
                break;
            }

            if (response + listOfAvailableWeights[rp] <= targetWeight)
            {
                response += listOfAvailableWeights[rp];
                rp--;
            }
            else if (response + listOfAvailableWeights[lp] <= targetWeight)
            {
                response += listOfAvailableWeights[lp];
                lp++;
            }
        }

        return response;
    }

    private string? FormatString(string s)
    {
        var stack = new Stack<char>();
        var sb = new StringBuilder();

        foreach (var i in s)
        {
            if (i == '#' && stack.Count() > 0)
            {
                stack.Pop();
            }
            else if (i != '#')
            {
                stack.Push(i);
            }
        }


        while (stack.Count() > 0)
        {
            sb.Append(stack.Pop());
        }
        return sb.ToString();
    }

    // https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
    // Works!
    
    public int StrStr(string haystack, string needle)
    {
        // If needle is longer than haystack, it's impossible to find
        if (needle.Length > haystack.Length)
        {
            return -1;
        }

        // Iterate through haystack, but stop early if the remaining length is shorter than needle
        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            // Check if the substring starting at i matches needle
            int j;
            for (j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] != needle[j])
                {
                    break; // Mismatch found, break out of inner loop
                }
            }

            // If the inner loop completed fully, we have found the needle
            if (j == needle.Length)
            {
                return i; // Return the starting index of the match
            }
        }

        // If no match is found, return -1
        return -1;
    }

    public string DefangIPaddr(string address)
    {
        var sb = new StringBuilder();
        foreach (var i in address)
        {
            if (i == '.')
            {
                sb.Append("[.]");
            }
            else
            {
                sb.Append(i);
            }
        }
        return sb.ToString();
    }

     // https://leetcode.com/problems/valid-palindrome/
     // Input: s = "A man, a plan, a canal: Panama" ====? Output: true
    // Explanation: "amanaplanacanalpanama" is a palindrome.
     public bool IsPalindrome(string s) {
       if(s.Length <= 1){
            return true;
       }

        s.Trim();
        Regex rgx = new Regex("[^a-zA-Z0-9 -]");
        var str = rgx.Replace(s.ToLower(), "");
       str =  Regex.Replace(str, @"\s", string.Empty);
       var l = 0; 
       var r = str.Length -1;
       while(r >=l){
        if(str[r] != str[l]){
            return false;
        }
        l ++;
        r --;
       }
       return true;
    }

}