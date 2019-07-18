using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class GamingComputerBuilder : ComputerBuilder
    {
        protected override void BuildEnclosure()
        {
            computer.BuildEnclosure("build gaming computer");
        }

        protected override void AddMotherBoard()
        {
            computer.AddMotherBoard("add gaming moter board");
        }

        protected override void AddCPU()
        {
            computer.AddCPU("add gaming cpu");
        }

        protected override void AddGPU()
        {
            computer.AddGPU("add gaming gpu");
        }

        protected override void AddMemory()
        {
            computer.AddMemory("add gaming memory");
        }
        protected override void RunTesting()
        {
            computer.runTesting("run gaming testing");
        }
    }
}
