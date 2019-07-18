using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class OfficeComputerBuilder : ComputerBuilder
    {
        protected override void BuildEnclosure()
        {
            computer.BuildEnclosure("build office computer");
        }

        protected override void AddMotherBoard()
        {
            computer.AddMotherBoard("add office moter board");
        }

        protected override void AddCPU()
        {
            computer.AddCPU("add office cpu");
        }

        protected override void AddGPU()
        {
            computer.AddGPU("add office gpu");
        }

        protected override void AddMemory()
        {
            computer.AddMemory("add office memory");
        }
        protected override void RunTesting()
        {
            computer.runTesting("run office testing");
        }
    }
}
