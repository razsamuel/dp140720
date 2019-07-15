using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Shape : ProtoType.IProtoType<Shape>
    {
        public int test;

        public abstract Shape clone();
    }
}
