using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lommeregner
{
    public class Calculator
    {
        double num1;
        double num2;
        int userchoice;

          public void usermenu()
        {
            Console.Clear();
            Console.WriteLine("MENU: ");
            Console.WriteLine("\n1. +  Add. \n2. - Subtract. \n3. * Multiply. \n4. /  Divide. \n5. Exit Program.");
            Console.WriteLine("Choose.");
        }


        public void userinput()
        {
            try
            {
                Console.Write("\nType the first number: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("\nType the second number: ");
                num2 = double.Parse(Console.ReadLine());
            }

            catch (FormatException)
            {
                Console.WriteLine("\n Not a valid format.");
                Console.WriteLine("\nPlease only use integers!");
                userinput();
            }
        }
        public void useroutput()
        {
            Console.WriteLine($"\n {userchoice} is not an option.");
            Console.WriteLine("\nPress enter to go back to menu.");
            Console.ReadLine();
        }

        public void add()
        {
            double result = num1 + num2;
            Console.WriteLine($"\n the sum of {num1} and {num2} is {result}");
            Console.Write("\n Press enter to go back to menu.");
            Console.ReadLine();
        }
        public void subtract()
        {
            double result = num1 + num2;
            Console.WriteLine($"\n the subtraction of {num1} and {num2} is {result}");
            Console.Write("\n Press enter to go back to menu.");
            Console.ReadLine();
        }
        public void multiply()
        {
            double result = num1 + num2;
            Console.WriteLine($"\n the ¨multiplication of {num1} and {num2} is {result}");
            Console.Write("\n Press enter to go back to menu.");
            Console.ReadLine();
        }
        public void divide()
        {
            try
            {
                double result = num1 + num2;
                Console.WriteLine($"\n the fraction of {num1} and {num2} is {result}");
                Console.Write("\n Press enter to go back to menu.");
                Console.ReadLine();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\ncannot divide by 0");
                Console.WriteLine("\nChoose an integer other than 0");
                Console.ReadLine();
            }
        }
    }
}
