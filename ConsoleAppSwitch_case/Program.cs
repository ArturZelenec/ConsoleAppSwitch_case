using System;

namespace ConsoleAppSwitch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Plese enter number:");
           int userInput = Convert.ToInt32(Console.ReadLine());

            //switch chek only what is in case
            switch (userInput) { 
            case 0:
                    Console.WriteLine("Number is 0");
                    break;
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case -1:
                    Console.WriteLine("Number is -1");
                    break;
                case 23:
                    Console.WriteLine("Number is 23");
                    break;
                case 41:
                    Console.WriteLine("Number is 41");
                    break;
                case 57:
                    Console.WriteLine("Number is 57");
                    break;
                case 11:
                    Console.WriteLine("Number is 11");
                    break;
                case 5:
                    Console.WriteLine("Number is 5");
                    break;
                default:
                    Console.WriteLine("Number is unrecognized");
                    break;
            }
        }
    }
}
