using System;
using MyLibrary; // Не забудьте добавить пространство имен вашей библиотеки

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            // Тестирование методов с типом void
            myClass.PrintMessage("My first Bibleoteka");
            myClass.AddNumbers(52, 887);

            // Тестирование методов с возвращаемыми значениями
            string greeting = myClass.GetGreeting("Dima");
            Console.WriteLine(greeting);

            int square = myClass.GetSquare(52);
            Console.WriteLine($"Square of 52 is: {square}");

            double area = myClass.GetCircleArea(222);
            Console.WriteLine($"Area of circle with radius 5222 is: {area}");

            // Ждем нажатия клавиши перед закрытием консоли
            Console.ReadKey();
        }
    }
}