using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Composite("Canvas root");
            Component circle1 = new Leaf("Circle 1");
            Component rectangle = new Leaf("Rectangle x");
         //   root.AddChild(circle1);
          //  root.AddChild(rectangle);

            Component container1 = new Composite("Container 1");
            Component circle2 = new Leaf("Circle 1");
            Component circle3 = new Leaf("Circle 2");
            container1.AddChild(circle2);
            container1.AddChild(circle3);

            root.AddChild(container1);

            Component container2 = new Composite("Container of triangles");
            Component t1 = new Leaf("Triangle 1");
            Component t2 = new Leaf("Triangle 2");
            Component t3 = new Leaf("Triangle 2");
            container2.AddChild(t1);
            container2.AddChild(t2);
          //  container2.AddChild(t3);
            root.AddChild(container2);

            root.Draw("");

            Console.WriteLine(root.countLeaf());
            Console.WriteLine(container1.countLeaf());
            Console.WriteLine(container2.countLeaf());
            Console.WriteLine(t1.countLeaf());

            Console.WriteLine(isBinary(root));
        }

        static Boolean isBinary(Component c)
        {
            if(c.GetChilds() == null)
            {
               return true;
            }
            Boolean isNodeBinary = c.isBinary();
            foreach(Component child in c.GetChilds()) {

                isNodeBinary = isNodeBinary && isBinary(child);
            }
            return isNodeBinary;
        }
    }
}
