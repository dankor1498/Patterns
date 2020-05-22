using System.Collections.Generic;

namespace Laptop
{
    public class Screen : AbstractLaptop
    {
        public Screen()
        {
        }

        public Screen(string name, double glass, double platium) : base(name)
        {
            Platinum = platium;
            Glass = glass;
        }

        public double Platinum { get; set; }
        public double Glass { get; set; }

        public override double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override List<AbstractLaptop> GetItems()
        {
            return new List<AbstractLaptop>() { this };
        }

        public override double GetSumOfPlastic()
        {
            return 0.0;
        }

        public override double GetSumOfValidMetal()
        {
            return this.Platinum;
        }
    }
}