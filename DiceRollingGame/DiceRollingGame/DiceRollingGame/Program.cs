using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            String Player1Name;
            String Player2Name;
            int CurrentDiceRoll;
            int Player1Total;
            int Player2Total;
            Random rnd = new Random();
            int total = 0;

            Console.WriteLine("Enter Player 1's Name: ");
            Player1Name = Console.ReadLine();
            Console.WriteLine("Greetings, " + Player1Name);

            Console.WriteLine("Enter Player 2's Name: ");
            Player2Name = Console.ReadLine();
            Console.WriteLine("Greetings, " + Player2Name);

            Console.WriteLine("Please enter an Integer to define the total score");
            total = Console.Read();
            Console.WriteLine("The target is " + total + ".");

            //Stops the application from exiting immediately
            Console.ReadKey();
        }
    }
}
