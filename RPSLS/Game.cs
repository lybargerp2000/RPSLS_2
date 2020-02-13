using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
       

        Player player1;
        Player player2;
        PlayerHuman playerHuman;
        PlayerComputer playerComputer;
        //string gestureChoosen;
        int Player1Score;
        int Player2Score;
        string Scissors;

        
        
        
        
        public Game()
        {
            playerHuman = new PlayerHuman();
            playerComputer = new PlayerComputer();
        }

       
        public void Player1Turn()
        {
            player1.ChooseGesture();

            player2.ChooseGesture();

        }
        public string GetNumberOfPlayers()
        {
            Console.WriteLine("1 or 2 Players");
            string numberPlayers = Console.ReadLine();
            return numberPlayers;
        }
        public void SetPlayers(string numberPlayers)
        {
            if (numberPlayers == "1")
            {
                player1 = new PlayerHuman();
                player2 = new PlayerComputer();
            }
            if (numberPlayers == "2")
            {
                player1 = new PlayerHuman();
                player2 = new PlayerHuman();

            }
        }
        public void CompareGestures()
        {

            if (Player1Turn 
            {
                
            }
        }
        
        // Method RunGame occurs within class when called out by program class "new game".
        public void RunGame()
        {
            string players = GetNumberOfPlayers();
            SetPlayers(players);
            Player1Turn();
            Player2Turn();
        
        }

    }
}
