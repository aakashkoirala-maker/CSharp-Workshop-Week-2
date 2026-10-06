namespace Task_3;

class Program
{
    static void Main(string[] args)
    {
        byte age = 20;
        short temperature = 25;
        int number = 1000;
        long population = 3000000000;
        float height = 5.7f;
        double price = 99.99;
        decimal salary = 50000.50m;
        char grade = 'A';
        bool isStudent = true;
        
        string numberAsString = 42.ToString();

        double decimalNumber = double.Parse("3.14");

        Console.WriteLine($"byte: {age}");
        Console.WriteLine($"short: {temperature}");
        Console.WriteLine($"int: {number}");
        Console.WriteLine($"long: {population}");
        Console.WriteLine($"float: {height}");
        Console.WriteLine($"double: {price}");
        Console.WriteLine($"decimal: {salary}");
        Console.WriteLine($"char: {grade}");
        Console.WriteLine($"bool: {isStudent}");
        Console.WriteLine($"Integer 42 converted to string: {numberAsString}");
        Console.WriteLine($"String 3.14 converted to double: {decimalNumber}");
    }
}
    