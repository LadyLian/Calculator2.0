namespace Calculator2._0
{
    internal class Program:Calculator
    {

            static void Main(String[] args)
        {
            Console.WriteLine("Enter the first number: ");
            var IsFirstNumber = double.TryParse(Console.ReadLine(), out double firstnum);
            if (IsFirstNumber == false)
            {
                Console.WriteLine("Sorry, try to enter the number!");

            }
            Console.WriteLine("Enter the second number: ");
            var IsSecondNumber = double.TryParse(Console.ReadLine(), out double secondnum);
            if (IsSecondNumber == false)
            {
                Console.WriteLine("Sorry, try to enter the number!");

            }
            ChoosingOperation(firstnum, secondnum);
        }
        

    }
}