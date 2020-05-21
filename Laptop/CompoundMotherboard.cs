using System;

namespace Laptop
{
    [Serializable]
    public class CompoundMotherboard : AbstractLaptop
    {
        public AbstractLaptop[] components;

        public CompoundMotherboard()
        {
        }

        public CompoundMotherboard(string name, RAM ram, CPU cpu, VideoCard videoCard) : base(name)
        {
            components = new AbstractLaptop[3] { ram, cpu, videoCard };
            Name = name;
        }

        public override double GetSumOfPlastic()
        {
            double sum = 0.0;
            foreach (var item in components)
            {
                sum += item.GetSumOfPlastic();
            }
            return sum;
        }

        public override double GetSumOfValidMetal()
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