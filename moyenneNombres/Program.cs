using System;

namespace moyenneNombres
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstNumber, secondNumber, thirdNumber, calculationOfTheAverage;

            Console.Write("Input a number: ");
            firstNumber = Convert.ToSingle(Console.ReadLine());

            Console.Write("Input a second number: ");
            secondNumber = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Input a third number: ");
            thirdNumber = Convert.ToSingle(Console.ReadLine());

            calculationOfTheAverage = (firstNumber + secondNumber + thirdNumber) / 3;
            Console.WriteLine("average of numbers= " + calculationOfTheAverage);

        }
    }
}
