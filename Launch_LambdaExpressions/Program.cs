class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Square(5));
        Console.WriteLine(Double(5));
    }

    static int Square(int number)
    {
        return number * number;
    }

    static int Double(int number)
    {
        return number * 2;
    }
}