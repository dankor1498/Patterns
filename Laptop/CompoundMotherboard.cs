using System;

namespace Laptop
{
    internal class CompoundMotherboard : ILaptop
    {
        private ILaptop[] components;
        public string Name { get; private set; }
        public CompoundMotherboard(string name, RAM ram, CPU cpu, VideoCard videoCard)
        {
            components = new ILaptop[3] { ram, cpu, videoCard };
            Name = name;
        }

        public double GetSumOfPlastic()
        {
            double sum = 0.0;
            foreach (var item in components)
            {
                sum += item.GetSumOfPlastic();
            }
            return sum;
        }

        public double GetSumOfValidMetal()
        {
            double sum = 0.0;
            foreach (var item in components)
            {
                sum += item.GetSumOfValidMetal();
            }
            return sum;
        }
    }
}