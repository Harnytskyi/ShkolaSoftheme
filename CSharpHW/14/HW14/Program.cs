using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14
{
    class Program
    {
        static Combination WinCombination;
        static Combination UserCombination;
        


        static void Main(string[] args)
        {
            WinCombination = new Combination();
            WinCombination.Generate();
            UserCombination = new Combination();
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine("Input {0} number from 0 to 9", i);
                var userNumber = Console.ReadLine();
                if (int.Parse(userNumber) >= 0 && int.Parse(userNumber) <= 9)
                {
                    UserCombination.AddNumber(int.Parse(userNumber));
                }
                else
                {
                    Console.WriteLine("The entered value is not valid");
                    i--;
                }
            }
            Console.WriteLine("Your combination: " + UserCombination.PrintNumbers());
            Console.WriteLine("Win combination:  " + WinCombination.PrintNumbers());
            Console.WriteLine("You " + HasUserWon());
            Console.ReadLine();

        }
        static string HasUserWon()
        {
            if (UserCombination.Equals(WinCombination) == true)
                return "win";
            else
                return "lose";
        }
    }
}
