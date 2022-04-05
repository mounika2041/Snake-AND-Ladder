using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to snake and ladder game");
            int playerPos = 0, rollDice;
            Random random = new Random();
            rollDice = random.Next(1, 7);
            Console.WriteLine("Rolled Dice number is:" + rollDice);
            Console.ReadLine();
        }
    }
}
