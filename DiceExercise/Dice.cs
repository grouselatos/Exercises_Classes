using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceExercise
{
    class Dice
    {
        public int Number;
        private Random dice = new Random();

        public void Roll()
        {
            Number = dice.Next(1, 7);
        }
    }
}
