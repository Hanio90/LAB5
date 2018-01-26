using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5

{ public class DiceRollerApp
    {
        public static int RollingDice(int x)
        {
            Random rnum = new Random();
            int die1 = rnum.Next(1, x);
            int die2 = rnum.Next(1, x);

            return die1 + die2;
        }
    }  
    class Program
    {
        static void Main(string[] args)
        {
            bool confirm = true;

            Console.WriteLine("Hello welcome to the Grand Circus Casino! \n\nWould you like to ROLL? Y/N");
            string response = Console.ReadLine();

            if (response == "Y" || response == "y")
            {
                while (confirm == true)
                {
                    Console.WriteLine("Enter the number of sides for a pair of dice");
                    int x = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    Console.WriteLine(DiceRollerApp.RollingDice(x));

                    int rolled = DiceRollerApp.RollingDice(x);

                    if (rolled == 2)
                    {
                        Console.WriteLine("SNAKE EYES!");
                    }
                    else if(rolled == 7)
                    {
                        Console.WriteLine("CRAPS OHH NOOOOOO!");
                    }
                    else if (rolled == 11)
                    {
                        Console.WriteLine("CRAPS OHH NOOOOOO!");
                    }
                    else if (rolled ==12 )
                    {
                        Console.WriteLine("BOX CARS!");
                    }
                    Console.WriteLine("Would you like to roll again ? Y/N");
                    response = Console.ReadLine();

                    if (response == "y" || response == "Y")

                        continue;
                    else
                        confirm = false;
                }
            }
            Console.WriteLine("Goodbye");
        }
    }
}
