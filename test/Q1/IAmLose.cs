using System;

namespace State
{
    public class IAmLose : IGameState
    {
        int life;

        public IAmLose(int life)
        {
            this.life = life;
        }

        public IGameState levelUp()
        {
            Console.WriteLine("You Lose");
            return this;
        }

        public IGameState reciveDamage()
        {
            Console.WriteLine("You Lose");
            return this;
        }
    }
}
