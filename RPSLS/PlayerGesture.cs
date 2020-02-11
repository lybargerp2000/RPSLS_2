using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class PlayerGesture
    {

        public string name;
        List<string> gestures;

        public PlayerGesture()
        {
            gestures = new List<string>();
        }
        public void AddToListOfGestures()
        {
            gestures.Add("Scissors");
            gestures.Add("Paper");
            gestures.Add("Rock");
            gestures.Add("Lizard");
            gestures.Add("Spock");

        }

    }
}
