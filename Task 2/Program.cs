namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
        double radius = 5;

        Console.WriteLine($"Value of PI: {Circle.PI}");
        Console.WriteLine($"Area: {Circle.CalculateArea(radius)}");
        Console.WriteLine($"Perimeter: {Circle.CalculatePerimeter(radius)}");

        //Circle.PI = 3.14159;
    }
}