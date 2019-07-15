using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class ShapeHolder : ProtoType.IProtoType<ShapeHolder>
    {
        List<Shape> shapes;

        public ShapeHolder()
        {
            shapes = new List<Shape>();
        }

        public void add(Shape shape)
        {
            shapes.Add(shape);
        }

        public void set(List<Shape> shapes)
        {
            this.shapes = shapes;
        }

        public ShapeHolder clone()
        {
            List<Shape> temp = new List<Shape>();
            foreach (Shape shape in shapes)
            {
                temp.Add(shape.clone());
            }
            ShapeHolder sh = new ShapeHolder();
            sh.set(temp);
            return sh;
        }

        public void toString()
        {
            foreach(Shape s in shapes)
            {
                Console.WriteLine(s);
            }
        }
    }
}
