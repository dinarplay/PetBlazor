using Microsoft.AspNetCore.Components;

namespace PetBlazor.Components
{
    public class TicTacToeModel : ComponentBase
    {
        public string[] arrOfCells { get; set; }
        public string result { get; set; } 
        public bool isTicTurn { get; set; }

        protected override void OnInitialized()
        {
            arrOfCells = new string[9];
            ClearGame();
        }
        public void ClearGame()
        {
            for (int i = 0; i < 9; i++)
            {
                arrOfCells[i] = "";
            }
            result = "";
        }

        public void CheckWinner(int numberOfCell)
        {

            if (arrOfCells[numberOfCell].Length == 0 && result.Length == 0)
            {
                if (isTicTurn)
                {
                    arrOfCells[numberOfCell] = "X";
                }
                else
                {
                    arrOfCells[numberOfCell] = "O";
                }

                if (isTicTurn && GetWinConditions("X"))
                {
                    result = "Tic win";
                }
                else if (!isTicTurn && GetWinConditions("O"))
                {
                    result = "Tac win";
                }
                else if (arrOfCells.All(x => x.Length > 0))
                {
                    result = "Tie";
                }

                isTicTurn = !isTicTurn;
            }
        }
        public bool GetWinConditions(string player)
        {
            for (int i = 0; i < 9; i += 3)
            {
                if (arrOfCells[i] == player && arrOfCells[i + 1] == player && arrOfCells[i + 2] == player)
                {
                    return true;
                }
            }

            // Vertical win conditions
            for (int i = 0; i < 3; i++)
            {
                if (arrOfCells[i] == player && arrOfCells[i + 3] == player && arrOfCells[i + 6] == player)
                {
                    return true;
                }
            }

            // Diagonal win conditions
            if (arrOfCells[0] == player && arrOfCells[4] == player && arrOfCells[8] == player)
            {
                return true;
            }

            if (arrOfCells[2] == player && arrOfCells[4] == player && arrOfCells[6] == player)
            {
                return true;
            }
            return false;
        }
    }
}
