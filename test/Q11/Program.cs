using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memento
{
    static class Program
    {
        static void Main()
        {
            Context context = new Context();
            PlayerMemento playerMemento = new PlayerMemento(1,1,1);
            // Context ctx = new Context();
            //  ctx.Save()
            PrintBoard(playerMemento);
           // context.Save(playerMemento.value, playerMemento.XIndex, playerMemento.YIndex);
            context.move(playerMemento , Context.DIRECTIONS.UP);
            context.move(playerMemento, Context.DIRECTIONS.UP);
            PrintBoard(playerMemento);
            playerMemento = context.LoadPrev(playerMemento);
            playerMemento = context.LoadPrev(playerMemento);
            playerMemento = context.LoadPrev(playerMemento);
            PrintBoard(playerMemento);
        }

        static void PrintBoard(PlayerMemento player)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------");
            int boardSize = 5;
            for(int i = 0; i< boardSize; i++)
            {
                Console.WriteLine();
                for(int j=0; j< boardSize; j++)
                {
                    if (i == player.YIndex && j == player.XIndex)
                    {
                        Console.Write('P');
                    }
                    else Console.Write('.');
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------");
        }
    }
}
