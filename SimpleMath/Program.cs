using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project: Simple Math Calculations");
            Console.WriteLine("Let's do some math!");
            Console.WriteLine("What is the first number?");

            var firstNumAsString = Console.ReadLine();
            int firstNumber;
            while (!int.TryParse(firstNumAsString, out firstNumber))
            {
                Console.WriteLine("Please enter a valid number.");
                firstNumAsString = Console.ReadLine();
            }
            if (firstNumber < 0)
            {
                Console.WriteLine("I cannot process negative values as this time, I have taken the absolute value of the number you entered.");
                firstNumber = Math.Abs(firstNumber);
            }

            Console.WriteLine("What is the second number?");
            var secondNumAsString = Console.ReadLine();
            int secondNumber;
            while (!int.TryParse(secondNumAsString, out secondNumber))
            {
                Console.WriteLine("Please enter a valid number.");
                secondNumAsString = Console.ReadLine();
            }
            if (secondNumber < 0)
            {
                Console.WriteLine("I cannot process negative values as this time, I have taken the absolute value of the number you entered.");
                secondNumber = Math.Abs(secondNumber);
            }


            int addition = firstNumber + secondNumber;
            int subtraction = firstNumber - secondNumber;
            int multiplication = firstNumber * secondNumber;
            int division = firstNumber / secondNumber;


            Console.WriteLine($"{firstNumber} + {secondNumber} = {addition} \n" +
                              $"{firstNumber} - {secondNumber} = {subtraction} \n" +
                              $"{firstNumber} * {secondNumber} = {multiplication} \n" +
                              $"{firstNumber} / {secondNumber} = {division}");
                              
        }
    }
}
