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
}