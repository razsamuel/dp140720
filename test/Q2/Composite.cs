using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Composite : Component
    {

        IList<Component> childs = new List<Component>();

        public Composite(int number) : base(number)
        {
        }

        public override void AddChild(Component c)
        {
            childs.Add(c);
        }

        public override IList<Component> GetChilds()
        {
            return childs;
        }

        public override void RemoveChild(Component c)
        {
            childs.Remove(c);
        }
        public override int SumTree()
        {
            int sum = this.number;
            foreach (Component c in childs)
            {
                sum += c.SumTree();
            }
            return sum;
        }

        public override bool isEvan()
        {
            return number % 2 == 0;
        }
    }
}
