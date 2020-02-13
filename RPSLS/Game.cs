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
        int player1Score;
        int player2Score;
        string Scissors;
        Player PlayersChoice;

        
        
        
        
        public Game()
        {
            playerHuman = new PlayerHuman();
            playerComputer = new PlayerComputer();
            player1Score = 0;
            player2Score = 0;

        }

       
        public void PlayerTurn()
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

            if (player1.gestureChoosen == "Scissors" && player2.gestureChoosen == "Paper")
            {
                player1Score++;  
            }
            else if (player1.gestureChoosen == "Paper" && player2.gestureChoosen == "Rock")
            {
                player2Score++;
            }
            else if (player1.gestureChoosen == "Rock" && player2.gestureChoosen == "Lizard")
            {
                player1Score++;
            }
        }
        
        // Method RunGame occurs within class when called out by program class "new game".
        public void RunGame()
        {
            string players = GetNumberOfPlayers();
            SetPlayers(players);
            PlayerTurn();

        
        }

    }
}
