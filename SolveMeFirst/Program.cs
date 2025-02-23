class Program
{
    static int solveMeFirst(int a, int b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        int val1 = Convert.ToInt32(3);
        int val2 = Convert.ToInt32(4);
        int sum = solveMeFirst(val1, val2);
        Console.WriteLine($"The sum is: {sum}");
        Console.ReadLine();
    }
}
