using System;

namespace DenaryToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Enter a denary number:");
            try
            {
                // read denary number
                number = int.Parse(Console.ReadLine());
                // convert to hex
                string hexNumber = number.ToString("X");
                // output hex number
                Console.WriteLine(number + " in hexidecimal is " + hexNumber);
            }
            catch
            {
                // if the user input is the wrong format
                Console.WriteLine("Incorrect value entered, please enter a denary integer");
            }
            
        }
    }
}
