using System;

namespace Laptop
{
    [Serializable]
    public class Cooler : AbstractLaptop
    {
        public Cooler()
        {
        }

        public Cooler(string name, double silver, double iron, double plastic) : base(name)
        {
            Silver = silver;
            Iron = iron;
            Plastic = plastic;
        }

        public double Silver { get; set; }
        public double Iron { get; set; }
        public double Plastic { get; set; }

        public override double GetSumOfPlastic()
        {
            return this.Plastic;
        }

        public override double GetSumOfValidMetal()
        {
            return this.Silver;
        }
    }
}