using Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape s = new Circle(new Point(5, 5), 50.5);
            ShapeHolder sh = new ShapeHolder();
            sh.add(s);
            sh.toString();

            DoStuffWithCircle((Circle)(s.clone()));

            sh.toString();
        }

        public static void DoStuffWithCircle(Circle c)
        {
            c.Center.X = 15;
            c.Area = -5;
        }
    }
}
