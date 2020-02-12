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

        List<string> gestures;
        public string gesturechoosen;

        public Player()
        {
            gestures = new List<string>();
        }
        public void AddGesture(List <string> gestures)
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
