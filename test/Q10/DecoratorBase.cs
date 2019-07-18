using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class DecoratorBase : IWindow
    {

        protected IWindow window;
        public abstract string GetDetails();

        public DecoratorBase(IWindow window)
        {
            this.window = window;
        }

    }
}
