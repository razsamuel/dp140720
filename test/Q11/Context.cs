using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Context
    {

       public enum DIRECTIONS
        {
            RIGHT ,
            LEFT,
            UP,
            DOWN
        }

        PlayerCareTaker careTake = new PlayerCareTaker();

        public void Save(int value , int XIindex , int YIndex)
        {
            careTake.AddMemento(new PlayerMemento(value , XIindex , YIndex));
        }

        public PlayerMemento LoadPrev(PlayerMemento playerMemento)
        {
            if (careTake.GetLast(false) != null)
            {
                playerMemento = careTake.GetLast(true);
            }
            return playerMemento;
        }

        public void move(PlayerMemento playerMemento, DIRECTIONS direction)
        {
            if (direction == DIRECTIONS.RIGHT)
            {
                playerMemento.XIndex += 1;
            }
            if (direction == DIRECTIONS.UP)
            {
                playerMemento.YIndex -= 1;

            }
            if (direction == DIRECTIONS.LEFT)
            {
                playerMemento.XIndex -= 1;
            }
            if (direction == DIRECTIONS.DOWN)
            {
                playerMemento.YIndex += 1;
            }

            if (playerMemento.XIndex < 0 || playerMemento.XIndex > 5 || playerMemento.YIndex < 0 || playerMemento.YIndex > 5)
            {
                PlayerMemento p = LoadPrev(playerMemento);
                if (p.XIndex < 0 || p.XIndex > 5 || p.YIndex < 0 || p.YIndex > 5)
                {
                    exitSimulation();
                }
                else
                {
                    playerMemento.value = p.value;
                    playerMemento.XIndex = p.XIndex;
                    playerMemento.YIndex = p.YIndex;
                }
                
            }
        }
        public void increaseNumber(PlayerMemento playerMemento)
        {
            playerMemento.value += 1;
        }
        public void decreaseNumber(PlayerMemento playerMemento)
        {
            playerMemento.value -= 1;
        }
        public void exitSimulation()
        {
            Console.WriteLine("Losing");
        }
    }
}
