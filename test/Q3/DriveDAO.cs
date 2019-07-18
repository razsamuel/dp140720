using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class DriveDAO : IDrive
    {
        public void accelerate()
        { 
            Console.WriteLine("accelerate");
        }

        public void decclerate()
        {
            Console.WriteLine("deccelerate");
        }

        public void endDrive()
        {
            Console.WriteLine("drive end");
        }

        public void getFuelState()
        {
            Console.WriteLine("the fuel state is good");
        }

        public void getLocation()
        {
            Console.WriteLine("the location is here");
        }

        public void startDrive()
        {
            Console.WriteLine("the drive started");
        }

        public void turnLeft()
        {
            Console.WriteLine("the car turn left");
        }

        public void turnRight()
        {
            Console.WriteLine("the car turn right");
        }
    }
}
