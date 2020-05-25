using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffetAssistant.Classes
{
    class TurnMaker
    {
        private static int turnNumber;
        private const int SIZE = 2000;

        public static int MakeTurn()
        {
            Random randomNumber = new Random(SIZE);
            turnNumber = randomNumber.Next();
            return turnNumber;
        }
    }
}
