using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farkle
{
    public class Dice
    {
        private int value;
        private bool marked;
        Random rnd = new Random();
        Player player;

        public Dice()
        { }

        public Dice(int value, bool marked)
        {
            this.value = value;
            this.marked = marked;

            marked = false;
        }

        public void rollDice()
        {
            int count = player.DiceAmount;

            while (count != 0)
            {
                rnd.Next(1,6);
            }
        }
        
        public int Value { get => value; set => this.value = value; }
        public bool Marked { get => marked; set => marked = value; }
    }
}
