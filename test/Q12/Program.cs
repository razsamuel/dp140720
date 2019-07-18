using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ComputerBuilder> menu = new List<ComputerBuilder>();
            menu.Add(new GamingComputerBuilder());
            menu.Add(new OfficeComputerBuilder());

            Computer comp = PrepareComputer(ComputerBuilderFactory.createComputer("Office"));
            comp.print();
        }
        static Computer PrepareComputer(ComputerBuilder builder)
        {
            builder.BuildComputer();
            return builder.GetComputer();
        }
    }
}
