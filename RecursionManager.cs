public class RecursionManager
{
    public RecursionManager()
    {

    }

    public int Factorial(int number)
    {
        if (number <= 1)
        {
            return number;
        }
        return number * Factorial(number - 1);
    }


    public int Fibonacci(int input)
    {
        if (input < 2) // fib 1 = 1, fib 0 = 0
        {
            return input;
        }
        return Fibonacci(input - 1) + Fibonacci(input - 2);
    }
}