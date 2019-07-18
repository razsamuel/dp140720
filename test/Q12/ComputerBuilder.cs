using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class ComputerBuilder
    {
        protected Computer computer;

        public Computer GetComputer()
        {
            if (computer == null)
                throw new ComputerNotReadyException("First prepare the computer!");

            return computer;
        }

        public void BuildComputer()
        {
            this.computer = new Computer();
            BuildEnclosure();
            AddMotherBoard();
            AddCPU();
            AddGPU();
            AddMemory();
            RunTesting();
        }

        protected abstract void BuildEnclosure();
        protected abstract void AddMotherBoard();
        protected abstract void AddCPU();
        protected abstract void AddGPU();
        protected abstract void AddMemory();
        protected abstract void RunTesting();
    }
}
