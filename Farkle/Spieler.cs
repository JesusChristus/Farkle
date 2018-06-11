namespace Farkle
{
    public class Spieler 
    {
        private int score;
        private string name;
        
        public Spieler(int score, string name)
        {
            this.Score = score;
            this.Name = name;
        }

        public void rollDice()
        {
            while(diceAmount != 0)
            {

            }
        }

        public int Score { get => score; set => score = value; }
        public string Name { get => name; set => name = value; }
    }
}
