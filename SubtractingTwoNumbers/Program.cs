using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtractingTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print name, version and name of creator in blue.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tSubtractTwoNumbers\tVer 1.0\tcreated by JB");

            // Console foreground color back to default.
            Console.ForegroundColor = ConsoleColor.Gray;

            // Ask the user to enter the number to be subtracted from.
            Console.WriteLine(" Please enter the Minuend (number to subtract from).");

            // Take the user input, which is a string, convert to a double, and then store it in a variable.
            double minuend = Convert.ToDouble(Console.ReadLine());

            // Ask the user to enter the number to subtract.
            Console.WriteLine(" Please enter the Subtrahend (number to subtract).");
            double subtrahend = Convert.ToDouble(Console.ReadLine());

            // Create a variable to store the answer in.
            double difference = (minuend - subtrahend);

            // Show the user the answer in green.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" When you take {minuend} and subtract {subtrahend} from it\n you get {difference} which is called the Difference.");

            // Keep the console open.
            Console.ReadKey();
        }
        // todo1 why does it do the program twice before closing? it happens because I used Console.ReadLine instead of Console.Read?
        //todo2 make a way for the program to continue.
        //todo3 make a way to exit the program.
        //todo4 check for valid input



    }
}
