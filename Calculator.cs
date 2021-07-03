using System.Collections.Generic;


namespace Practise
{
    public class Calculator
    {
        public static double Add(List<double> numbers)
        {
            double result = 0;
            foreach (double number in numbers)
            {
                result += number;
            }
            return result;
        }

        public static double Subtract(List<double> numbers)
        {
            double result = numbers[0] - numbers[1];
            for (int i = 2; i < numbers.Count; i++)
            {
                result -= numbers[i];
            }
            return result;
        }

        public static double Product(List<double> numbers)
        {
            double result = 1;
            foreach (double number in numbers)
            {
                result *= number;
            }
            return result;
        }

        public static double Divide(List<double> numbers)
        {
            double result = numbers[0] / numbers[1];
            for (int i = 2; i < numbers.Count; i++)
            {
                result /= numbers[i];
            }
            return result;
        }
    }
}