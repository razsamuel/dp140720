using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    interface IDrive
    {
        void startDrive();

        void endDrive();

        void accelerate();

        void decclerate();

        void turnRight();

        void turnLeft();

        void getFuelState();

        void getLocation();
    }
}
