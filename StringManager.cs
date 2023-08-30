using System.Text;

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
}