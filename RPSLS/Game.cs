using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        public string player1;
        public string player2;
        PlayerHuman playerHuman;
        PlayerComputer playerComputer;
        public Game() 
        {
            playerHuman = new PlayerHuman();
            playerComputer = new PlayerComputer();
        }
        public void Player1Turn()
        {
         
        }
        public string GetNumberOfPlayers()
        {
            Console.WriteLine("1 or 2 Players");
            string numberPlayers = Console.ReadLine();
            return numberPlayers;
        }
        public void SetPlayers(string numberPlayers)
        {
         if(numberPlayers == "1")
            {
                player1 = new playerHuman;
                player2 = new playerComputer; 
            }
          if(numberPlayers == "2")
            {
                player1 = playerHuman;
                player2 = PlayerHuman();
             
            }
        }
        public void RunGame()
        {
            string players = GetNumberOfPlayers();
            SetPlayers(players);
            player1.ChooseGesture();

        }

    }
}
