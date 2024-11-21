using System; 
namespace MyLibrary
{
    public class MyClass 
    {
        // Метод с типом void
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        // Второй метод с типом void
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine($"Sum: {a + b}");
        }

        // Метод с возвращаемым значением типа string
        public string GetGreeting(string name)
        {
            return $"Hello, {name}!";
        }

        // Метод с возвращаемым значением типа int
        public int GetSquare(int number)
        {
            return number * number;
        }

        // Метод с возвращаемым значением типа double
        public double GetCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
