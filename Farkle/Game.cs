using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farkle
{
    class Game
    {
        private Player p1;
        private Player p2;
        private List<Dice> dicesOnBoard;
        private List<Dice> dicesHold;
        private int diceAmount;
        private int goal;

        public Game()
        {
            DiceAmount = 6;
            goal = /*bei spielbeginn festlegen; value über die gui holen*/;
            Player p1 = new Player(0, 0, /*bei spielbeginn festlegen; value über die gui holen*/);
            Player p2 = new Player(0, 0, /*bei spielbeginn festlegen; value über die gui holen*/);

            dicesOnBoard = new List<Dice>();
            dicesHold = new List<Dice>();

            actionOrder();
        }

        private void actionOrder()
        {
            rollDice();

            calculateScoreRolled();

            addScoreToTotalScore();

            checkWinCondition();

            endTurn();
        }

        private void rollDice()
        {

        }

        private void calculateScoreRolled()
        {

        }
        
        private void addScoreToTotalScore()
        {
            
        }

        private void checkWinCondition()
        {
            
        }

        private void endTurn()
        {
            
        }

        public int DiceAmount { get => diceAmount; set => diceAmount = value; }
        public int Goal { get => goal; set => goal = value; }
    }
}
