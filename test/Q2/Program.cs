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
            Component root = new Composite(1);
            Component circle1 = new Leaf(2);
            Component rectangle = new Leaf(3);
            root.AddChild(circle1);
            root.AddChild(rectangle);

            Component container1 = new Composite(4);
            Component circle2 = new Leaf(5);
            Component circle3 = new Leaf(6);
            container1.AddChild(circle2);
            container1.AddChild(circle3);

            root.AddChild(container1);

            Component container2 = new Composite(7);
            Component t1 = new Leaf(8);
            Component t2 = new Composite(8);
            Component t3 = new Leaf(12);
            container2.AddChild(t1);
            container2.AddChild(t2);
            t2.AddChild(t3);
          //  container2.AddChild(t3);
            root.AddChild(container2);

            Console.WriteLine(container2.SumTree());
            Console.WriteLine(isEvan(t2));
        }

        static Boolean isEvan(Component c)
        {
            if (c.GetChilds() == null)
            {
                return c.isEvan();
            }
            Boolean isNodeEvan = c.isEvan();
            foreach (Component child in c.GetChilds())
            {
                isNodeEvan = isNodeEvan && isEvan(child);
            }
            return isNodeEvan;
        }

    }
}
