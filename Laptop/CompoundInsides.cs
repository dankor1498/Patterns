using System;

namespace Laptop
{
    [Serializable]
    public class CompoundInsides : AbstractLaptop
    {
        public AbstractLaptop[] components;

        public CompoundInsides()
        {
        }

        public CompoundInsides(string name, CompoundMotherboard compoundMotherboard, Cooler cooler) : base(name)
        {
            components = new AbstractLaptop[2] { compoundMotherboard, cooler };
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