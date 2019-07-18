using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Computer
    {

        private List<String> ingredients = new List<String>();

        public Computer()
        {
        }

        public void BuildEnclosure(String enclosure)
        {
            ingredients.Add(enclosure);
        }

        public void AddMotherBoard(String mBoard)
        {
            ingredients.Add(mBoard);
        }

        public void AddCPU(String cpu)
        {
            ingredients.Add(cpu);
        }

        public void AddGPU(String gpu)
        {
            ingredients.Add(gpu);
        }

        public void AddMemory(String memory)
        {
            ingredients.Add(memory);
        }
        public void runTesting(string test)
        {
            ingredients.Add(test);
        }
        public void print()
        {
            Console.WriteLine("ingredients:");
            foreach (String ingredient in this.ingredients)
            {
                Console.WriteLine(ingredient);
            }
        }
    }
}
