using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();

            for (int i = 0; i < 10; i++)
            {

                Console.Write("Insert a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                dice.Roll();
                if (number == dice.Number)
                {
                    Console.WriteLine("Kerdises");
                }
                else
                {
                    Console.WriteLine("Exases");
                }
            }

            Console.ReadKey();
        }
    }
}
