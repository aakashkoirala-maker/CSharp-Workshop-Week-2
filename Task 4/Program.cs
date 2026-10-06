namespace Task_4;

class Program
{
    static void Main(string[] args)
    {
        int[] favoriteNumbers = { 7, 3, 10, 5, 1 };

        Array.Sort(favoriteNumbers);

        Console.WriteLine("Sorted array:");

        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }

        Array.Reverse(favoriteNumbers);

        Console.WriteLine("\nReversed array:");

        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }

        int position = Array.IndexOf(favoriteNumbers, 7);

        Console.WriteLine($"\nPosition of 7: {position}");
    }
}