using System;

namespace State
{
    public class IAmWin : IGameState
    {
        int life;

        public IAmWin(int life)
        {
            this.life = life;
        }

        public IGameState levelUp()
        {
            Console.WriteLine("You Win");
            return this;
        }

        public IGameState reciveDamage()
        {
            Console.WriteLine("You Win");
            return this;
        }
    }
}
