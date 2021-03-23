using System;

namespace Calculators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In The Name Of Allah");

            Console.WriteLine("Please Enter Number 1 ?");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Number 2 ?");
            int number2 = int.Parse(Console.ReadLine());

            Calculator calculator = new Calculator();

            Console.WriteLine("Plus : "+calculator.Plus(number1,number2));
            Console.WriteLine("Minus : "+calculator.Minus(number1,number2));
            Console.WriteLine("Division : "+calculator.Division(number1,number2));
            Console.WriteLine("Multiplication : "+calculator.Multiplication(number1,number2));

            Console.ReadKey();
        }
    }
}
