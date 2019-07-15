using Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    public class Rectangle : Prototype.Shape
    {

        public Point topRight;
        public Point topLeft;
        public int width;
        public int height;


        public Rectangle(Point topLeft, Point topRight , int width , int height )
        {
            this.topLeft = topLeft;
            this.topRight = topRight;
            this.width = width;
            this.height = height;
        }

        public override string ToString()
        {
            return $"Rectangle corners {topRight} { topLeft } { topLeft.X - width } , {topLeft.Y - height } { topRight.X - width } , {topRight.Y - height }";
        }

        public override Shape clone()
        {
            return new Rectangle(topLeft.clone(), topRight.clone() , width , height);
        }
    }
}
