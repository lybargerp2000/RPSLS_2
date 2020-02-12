using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class PlayerComputer : Player 
    {
        public PlayerComputer(string name)
        {
            this.name = "Computer";
        }

        public override void ChooseGesture()
        {
            Console.WriteLine("Choose a Gesture of Scissors, Paper, Rock, Lizard, or Spock");

            gesturechoosen = Console.ReadLine();

        }
    }
}
