namespace Laptop
{
    internal class CompoundBody : ILaptop
    {
        private ILaptop[] components;
        public string Name { get; private set; }

        public CompoundBody(string name, Keyboard keyboard, Screen screen, Touchpad touchpad)
        {
            components = new ILaptop[3] { keyboard, screen, touchpad };
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