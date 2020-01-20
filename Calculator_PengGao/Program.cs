using System;

namespace Calculator_PengGao
{
    class Program
    {
        static void Main(string[] args)
        {
            //declair two variables for calculation
            double num1; double num2;

            //declair a boolean variable to control the app's runing or ending 
            bool endApp = false;
            
            //display title
            Console.WriteLine("Console Calculator in C#");
            Console.WriteLine("------------------------");

            while (!endApp)
            {
                //ask user to type the first number
                Console.WriteLine("Type a number, and then press Enter");
                num1 = Convert.ToDouble(Console.ReadLine());

                //ask user to type the second number
                Console.WriteLine("Type another number, and then press Enter");
                num2 = Convert.ToDouble(Console.ReadLine());

                //ask user to choose an operator
                Console.WriteLine("Choose an operator form the list:");
                Console.WriteLine("+ --- Add");
                Console.WriteLine("- --- Substract");
                Console.WriteLine("* --- Multiply");
                Console.WriteLine("/ --- Divide");
                Console.WriteLine("Please enter your operator:");

                //use switch control to calculate
                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine("The result: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "-":
                        Console.WriteLine("The result: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "*":
                        Console.WriteLine("The result: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "/":
                        //user has to enter a non-zero divisor
                        while (num2 == 0)
                        {
                            Console.WriteLine("Please enter a non-zero divisor: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine("The result: {num1} / {num2} = " + (num1 / num2));
                        break;
                }

                // Wait for the user to respond before closing the app...
                Console.Write("Press 'x' and enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "x") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}
