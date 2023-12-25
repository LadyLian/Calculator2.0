using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2._0
{
    internal class Calculator
    {
        public static void ChoosingOperation(double firstnum, double secondnum)
        {
            Console.WriteLine("Enter the type of operation");
            var operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Sum(firstnum, secondnum);
                    break;
                case "-":
                    Subtraction(firstnum, secondnum);
                    break;
                case "*":
                    Multiplication(firstnum, secondnum);
                    break;
                case "/":
                    Division(firstnum, secondnum);
                    break;
                default:
                    Console.WriteLine("Choose correct operation");
                    break;
            }
        }
        static void Sum(double firstnum, double secondnum)
        {
            var numbersum = firstnum + secondnum;
            Console.WriteLine("The sum of " + firstnum + " + " + secondnum + "= " + numbersum);
        }
        static void Sum(int firstnum, int secondnum)
        {
            var numbersum = firstnum + secondnum;
            Console.WriteLine("The sum of " + firstnum + " + " + secondnum + "= " + numbersum);
        }
        static void Subtraction(double firstnum, double secondnum)
        {
            var numbersub = firstnum - secondnum;
            Console.WriteLine("The subtraction of " + firstnum + " - " + secondnum + "= " + numbersub);
        }
        static void Subtraction(int firstnum, int secondnum)
        {
            var numbersub = firstnum - secondnum;
            Console.WriteLine("The subtraction of " + firstnum + " - " + secondnum + "= " + numbersub);
        }
        static void Multiplication(double firstnum, double secondnum)
        {
            var numbermulti = firstnum * secondnum;
            Console.WriteLine("The subtraction of " + firstnum + " * " + secondnum + "= " + numbermulti);
        }
        static void Multiplication(int firstnum, int secondnum)
        {
            var numbermulti = firstnum * secondnum;
            Console.WriteLine("The subtraction of " + firstnum + " * " + secondnum + "= " + numbermulti);
        }
        static void Division(double firstnum, double secondnum)
        {
            if (secondnum == 0)
            {
                Console.WriteLine("Sorry, you can`t divide by 0!");
            }
            else
            {
                var numberdivis = firstnum / secondnum;
                Console.WriteLine("The subtraction of " + firstnum + " / " + secondnum + "= " + numberdivis);
            }
        }
        static void Division(int firstnum, int secondnum)
        {
            var numberdivis = firstnum / secondnum;
            Console.WriteLine("The subtraction of " + firstnum + " / " + secondnum + "= " + numberdivis);
        }
    }
}
