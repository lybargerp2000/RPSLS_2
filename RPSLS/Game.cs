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
        //PlayerHuman playerHuman;
        //PlayerComputer playerComputer;
        //public Game()
        //{
        //    playerHuman = new PlayerHuman();
        //    playerComputer = new PlayerComputer();
        //}
    
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
                player1 = PlayerHuman();
                player2 = PlayerComputer();
            }
          if(numberPlayers == "2")
            {
                player1 = PlayerHuman();
                player2 = PlayerHuman();
             
            }
        }

        private string PlayerComputer()
        {
            new PlayerComputer();
            return PlayerComputer();
        }

        private string PlayerHuman()
        {
            new PlayerHuman();
            return PlayerHuman();
        }
        // Method RunGame occurs within class when called out by program class "new game".
        public void RunGame()
        {
            string players = GetNumberOfPlayers();
            SetPlayers(players);
            PlayerComputer();
            PlayerHuman();
           


        }

    }
}
