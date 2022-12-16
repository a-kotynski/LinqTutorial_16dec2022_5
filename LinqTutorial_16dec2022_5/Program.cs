namespace LinqTutorial_16dec2022_5;
//Any()

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = new[] { 5, 9, 2, 12, 6 };
        bool isAnyLargerThan10 = numbers.Any(number => number > 10);
        if (isAnyLargerThan10 == true)
        {
            Console.WriteLine("There's a number larger than 10!");
        }
        else Console.WriteLine("No numbers larger than 10.");
    }
}