using System;
using System.Collections.Generic;

namespace Farkle
{
    
    public class Player 
    {
        private int score;
        private int totalScore;
        private string name;
        private int diceAmount;
        private int diceValue;

        public Player()
        { }

        public Player(int score, int totalScore, string name, int diceValue)
        {
            this.Score = score;
            this.totalScore = totalScore;
            this.Name = name;


        }

        private int resetScoreRolled()
        {
            score = 0;
            return score;
        }

        private void addScore()
        {
            totalScore += score;
        }

        public void markDice(Dice dice)
        {
            if(dice.Marked == false)
            { 
                dice.Marked = true;
            }
            else
            {
                dice.Marked = false;
            }
        }

        public int Score { get => score; set => score = value; }
        public string Name { get => name; set => name = value; }
        public int TotalScore { get => totalScore; set => totalScore = value; }
    }
}
        