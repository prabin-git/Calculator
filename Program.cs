using System;
using System.Collections.Generic;
using System.Linq;

namespace Practise

{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>();
            char operation;
            int newline = 40;

            while (true)
            {
                Util.NewLine(newline);
                //Take operation input
                operation = Util.InputOperator();

                // //Add 50 linebreaks
                Util.NewLine(newline);

                //Take list of inputs
                numbers = Util.ListDouble();

                Util.NewLine(newline);

                //Perform operation
                Util.PerformOperation(operation, numbers);

                Console.Write("Press Enter to continue");
                Console.ReadLine();
                Util.NewLine(newline);


                Console.WriteLine("Do you want to perform another operation?\nEnter 'Y' or 'N'");
                Console.Write(">");
                char input = char.ToUpper(Console.ReadLine()[0]);
                if (input == 'Y')
                {
                    Util.NewLine(newline);
                    continue;
                }
                break;
            }

        }

        public static class Util
        {
            public static char InputOperator()
            {
                char operation;
                while (true)
                {
                    Console.WriteLine("Select appropriate option for performing specific opration\n1. 'A' for Addition\n2. 'S' for Subtraction\n3. 'P' for Product\n4. 'D' for Division");
                    Console.Write("> ");
                    operation = char.ToUpper(Console.ReadLine().ToCharArray()[0]);
                    if (operation == 'A' || operation == 'S' || operation == 'P' || operation == 'D')
                    {
                        break;
                    }
                    Console.WriteLine("Invalid operation entered. Please try again!\n\n-----------------------------------------------------------------\n");
                    continue;
                }
                return operation;
            }

            public static void NewLine(int num)
            {
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine(" ");
                }
            }

            public static List<double> ListDouble()
            {
                List<double> numbers = new List<double>();
                while (true)
                {
                    Console.WriteLine("Enter numbers seperated by comma (,)\nNote* Atleast 2 numbers should be entered");
                    Console.Write("> ");
                    string inputs = Console.ReadLine();
                    string noSpaceInput = inputs.Replace(" ", "");
                    List<string> Listinputs = noSpaceInput.Split(',').ToList();
                    List<double> tempList = new List<double>();
                    foreach (string number in Listinputs)
                    {
                        double num;
                        if (double.TryParse(number, out num))
                        {
                            tempList.Add(num);
                        }
                    }

                    if (tempList.Count < 2)
                    {
                        Console.WriteLine("Atleast 2 numbers are required. Enter again!\n\n-----------------------------------------------------------------\n");
                        continue;
                    }
                    else
                    {
                        numbers = numbers.Concat(tempList).ToList();
                        return numbers;
                    }
                }
            }

            public static void PerformOperation(char operation, List<double> numbers)
            {
                switch (operation)
                {
                    case 'A':
                        Console.WriteLine("Addition operation performed returned " + Calculator.Add(numbers));
                        break;

                    case 'S':
                        Console.WriteLine("Subtraction operation performed returned " + Calculator.Subtract(numbers));
                        break;

                    case 'D':
                        Console.WriteLine("Division operation performed returned " + Calculator.Divide(numbers));
                        break;

                    case 'P':
                        Console.WriteLine("Product operation performed returned " + Calculator.Product(numbers));
                        break;
                }
            }
        }
    }
}
