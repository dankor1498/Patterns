namespace Laptop
{
    internal class CompoundInsides : ILaptop
    {
        private ILaptop[] components;
        public string Name { get; private set; }

        public CompoundInsides(string name, CompoundMotherboard compoundMotherboard, Cooler cooler)
        {
            components = new ILaptop[2] { compoundMotherboard, cooler };
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