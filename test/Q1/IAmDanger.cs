using System;

namespace State
{
    public class IAmDanger : IGameState
    {
        int life;
        int level;

        public IAmDanger(int life , int level)
        {
            this.life = life;
            this.level = level;
        }

        public IGameState levelUp()
        {
            if (level++ == 3)
            {
                return new IAmWin(life);
            }
            return this;
        }

        public IGameState reciveDamage()
        {
            Console.WriteLine("you get hurt in dangar state");

            if (--life == 0)
            {
                return new IAmLose(life);
            }

            return this;
        }
    }
}
