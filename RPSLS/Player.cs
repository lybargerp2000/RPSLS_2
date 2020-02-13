using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {

        //public string name;

        public List<string> gestures;
        public string gestureChoosen;

        public Player()
        {
            gestures = new List<string>();
            return;
        }
        public void AddGesture()
        {
            gestures.Add("Scissors");
            gestures.Add("Paper");
            gestures.Add("Rock");
            gestures.Add("Lizard");
            gestures.Add("Spock");

        }
        //Has to do this frocing players to choose fale safe
        public abstract void ChooseGesture();
        
         
       

    }
}
