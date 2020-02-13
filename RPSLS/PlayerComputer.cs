using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class PlayerComputer : Player 
    {
        //public PlayerComputer(string name)
        //{
        // this.name = "Computer";
        //}
        Random ComputerChoice = new Random();
        public PlayerComputer()
        {
            AddGesture();

        }
        

        public override void ChooseGesture()
        {
            int val  = ComputerChoice.Next(0, 5);
            gestureChoosen = gestures[val];

            return;
          
        }
    }
}
