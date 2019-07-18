using System;

namespace State
{
    public class IAmFix : IGameState
    {
        int life;
        int level;

        public IAmFix(int life , int level)
        {
            this.life = life;
            this.level = level;
        }

        public IGameState levelUp()
        {
            Console.WriteLine("level up!");
            if (level++ == 3)
            {
                return new IAmWin(life);
            }
            return this;
        }

        public IGameState reciveDamage()
        {
            Console.WriteLine("you get hurt");
            if (--life == 10)
            {
                Console.WriteLine("start danger state");
                return new IAmDanger(life,level);
                
            }
            return this;
        }
    }
}
