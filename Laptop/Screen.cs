using System.Collections.Generic;

namespace Laptop
{
    public class Screen : AbstracComponent
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

        public override List<AbstracComponent> GetItems()
        {
            return new List<AbstracComponent>() { this };
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