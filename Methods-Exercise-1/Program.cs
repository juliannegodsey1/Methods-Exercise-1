using System;

namespace Methods_Exercise_1
{
    internal class Program
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }



        static void Main(string[] args)
        {
            var amountOfCars = Sum(2, 7);

            Console.WriteLine("Hello, what is your name?");
            var userName = Console.ReadLine();
Console.WriteLine($"Hi {userName}! What is your favorite color?");
            var favColor = Console.ReadLine();
            Console.WriteLine($"I like the color {favColor} too! What is your favorite season?");
            var favSeason = Console.ReadLine();
            Console.WriteLine("Great! What is your favorite animal?");
            var favAnimal = Console.ReadLine();
            Console.WriteLine("Thanks! Here is your profile:");
            Console.WriteLine("----------------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Color: {favColor}");
            Console.WriteLine($"Favorite Season: {favSeason}");
            Console.WriteLine($"Favorite Animal: {favAnimal}");
            Console.WriteLine("");
            Console.WriteLine($"Goodbye, {userName}!");
    
        }
        
       

      
      
            int amountOfCars = Sum(2, 7);
       

    }
}
