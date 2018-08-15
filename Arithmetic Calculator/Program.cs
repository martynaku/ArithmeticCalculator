using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Calculator
{
    class Program
    {
        static void Main()
        {

            var finalResult = 0.0;

            string greeting = "Welcome to Arithmetic Calculator.\nIn a minute you'll be asked for numbers and operators to creat your equation\nif you wish to quit type\"quit\" at any point. ";
            string promptNumber1 = "Enter the first number for the equation";
            string promptNumber2 = "Enter the other number for the equation";
            string promptOperator = "Enter the first operator for the equation for example + - / * ^";



            Console.WriteLine(greeting);

            //Console.WriteLine(promptOperator);
            //var userEntryOperator = Console.ReadLine();
            //Console.WriteLine(promptOperator.GetType());


            //Prompt the user for a number.
            //Prompt the user for an operation (+- / *).
            //Prompt the user for another number.
            //Perform the operation.
            //Print the result to the screen.
            //Repeat until the user types in “quit” at any of the prompts.


            while (true)
            {
                //Prompt the user for a number.
                Console.WriteLine(promptNumber1);
                var userEntryNumber1 = Console.ReadLine();

                if (userEntryNumber1.ToLower() == "quit")
                {
                    break;
                }


                //Prompt the user for an operation (+- / *).
                Console.WriteLine(promptOperator);
                var userEntryOperator = Console.ReadLine();

                if (userEntryOperator.ToLower() == "quit")
                {
                    break;
                }


                //Prompt the user for another number
                Console.WriteLine(promptNumber2);
                var userEntryNumber2 = Console.ReadLine();

                if (userEntryNumber2.ToLower() == "quit")
                {
                    break;
                }


                //Repeat until the user types in “quit” at any of the prompts.


                //Perform the operation.
                try
                {
                    double number1 = double.Parse(userEntryNumber1);
                    double number2 = double.Parse(userEntryNumber2);


                    if (userEntryOperator == "+")
                    {
                        finalResult = number1 + number2;
                        Console.WriteLine("The result is " + finalResult);
                    }
                    else if (userEntryOperator == "-")
                    {
                        finalResult = number1 - number2;
                        Console.WriteLine("The result is " + finalResult);
                    }
                    else if (userEntryOperator == "/")
                    {
                        finalResult = number1 / number2;
                        Console.WriteLine("The result is " + finalResult);

                    }
                    else if (userEntryOperator == "*")
                    {
                        finalResult = number1 * number2;
                        Console.WriteLine("The result is " + finalResult);
                    }
                    else if (userEntryOperator == "^")
                    {
                        finalResult = Math.Pow(number1, number2);
                        Console.WriteLine("The result is " + finalResult);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is invalid input.");
                    continue;
                }


                //Console.WriteLine(promptNumber1);

                //var userEntryNumber1 = Console.ReadLine();

                //if (userEntryNumber1.ToLower() == "quit")
                //{
                //    break;
                //}



                //Console.WriteLine(promptOperator);

                //var userEntryOperator = Console.ReadLine();

                //if (userEntryNumber1.ToLower() == "quit")
                //{
                //    break;
                //}

                //try
                //{
                //    if (userEntryOperator == "+")
                //    {
                //        Sum.CalculateSum(number1, number2);

                //    }
                //    var number1 = double.Parse(userEntryNumber1);
                //}

                //Console.WriteLine(promptNumber2);

                //var userEntryNumber2 = Console.ReadLine();

                //var number2 = double.Parse(userEntryNumber2);

                //Console.WriteLine(waitMessage + userEntryNumber1 + " " + userEntryOperator + " " + userEntryNumber2);

                //try
                //{
                //    if (userEntryOperator == "+")
                //    {
                //        Sum.CalculateSum(number1, number2);

                //    }
                //    else if (userEntryOperator == "-")
                //    {
                //    }
                //    else if (userEntryOperator == "*")
                //    {
                //    }
                //    else if (userEntryOperator == "/")
                //    {

                //    }
                //    else if (userEntryOperator == "^")
                //    {

                //    }
                //}
                //catch(FormatException)
                //{

                //}


            }
            Console.ReadLine();
        }
    }
}


