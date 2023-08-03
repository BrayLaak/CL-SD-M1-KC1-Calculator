using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    string addNumber1, addNumber2;
                    CollectInput(input, out addNumber1, out addNumber2);
                    

                    if (int.TryParse(addNumber1, out int addNumOne) && int.TryParse(addNumber2, out int addNumTwo))
                    {
                        Console.Write($"{addNumber1} + {addNumber2} = ");
                        Console.Write(calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "2":
                    string subtractNumber1, subtractNumber2;
                    CollectInput(input, out subtractNumber1, out subtractNumber2);

                    if (int.TryParse(subtractNumber1, out int subNumOne) && int.TryParse(subtractNumber2, out int subNumTwo))
                    {
                        Console.Write($"{subtractNumber1} - {subtractNumber2} = ");
                        Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "3":
                    string multiplyNumber1, multiplyNumber2;
                    CollectInput(input, out multiplyNumber1, out multiplyNumber2);

                    if (int.TryParse(multiplyNumber1, out int multNumOne) && int.TryParse(multiplyNumber2, out int multNumTwo))
                    {
                        Console.Write($"{multiplyNumber1} * {multiplyNumber2} = ");
                        Console.Write(calculator.Multiply(multNumOne, multNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "4":
                    string divideNumber1, divideNumber2;
                    CollectInput(input, out divideNumber1, out divideNumber2);

                    if (double.TryParse(divideNumber1, out double divNumOne) && double.TryParse(divideNumber2, out double divNumTwo))
                    {
                        Console.Write($"{divideNumber1} / {divideNumber2} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }

        private static void CollectInput(string menuOption,out string inputNumber1, out string inputNumber2)
        {
            switch (menuOption)
            {
                case "1":
                    Console.WriteLine("Enter 2 integers to add");
                    inputNumber1 = Console.ReadLine();
                    inputNumber2 = Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                    inputNumber1 = Console.ReadLine();
                    inputNumber2 = Console.ReadLine();
                    break;

                 case "3":
                    Console.WriteLine("Enter 2 integers to multiply");
                    inputNumber1 = Console.ReadLine();
                    inputNumber2 = Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide");
                    inputNumber1 = Console.ReadLine();
                    inputNumber2 = Console.ReadLine();
                    break;

                default :
                    inputNumber1 = null;
                    inputNumber2 = null;
                    break;
            }
            
        }
    }
}