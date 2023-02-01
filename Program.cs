using System;

namespace InfixCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Приветствие пользователя с просьбой ввести выражение. 
            Console.WriteLine("Welcome to the Infix Calculator!");
            Console.Write("Please enter an expression: ");

            // Получаем выражение от пользователя. 
            string expression = Console.ReadLine();

            // Сохраняем число, разделяя его на цифры. 
            string[] numbers = expression.Split('+', '-', '*', '/');

            // Здесь сохраняются результаты, которые мы будем использовать.  
            double result = 0;

            // Cначала умножаем, а потом - складываем/вычитаем.  
            for (int i = 0; i < expression.Length; i++)
            {

                if (expression[i] == '*')
                {

                    result += Convert.ToDouble(numbers[i]) * Convert.ToDouble(numbers[i + 1]);

                    numbers[i + 1] = result.ToString();

                }
                else if (expression[i] == '/')
                {

                    result += Convert.ToDouble(numbers[i]) / Convert.ToDouble(numbers[i + 1]);

                    numbers[i + 1] = result.ToString();

                }
                else if (expression[i] == '+')
                {

                    result += Convert.ToDouble(numbers[i]) + Convert.ToDouble(numbers[i + 1]);

                    numbers[i + 1] = result.ToString();

                }
                else if (expression[i] == '-')
                {

                    result += Convert.ToDouble(numbers[i]) - Convert.ToDouble(numbers[i + 1]);
                }
            }
            Console.ReadKey();
        }
    }
}