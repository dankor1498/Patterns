using System;

namespace Laptop
{
    internal class Screen : AbstractComponent, ILaptop
    {
        public Screen(string name, double gold, double silver, double platium, double plastic) : base(name, gold, silver, platium, plastic)
        {
        }

        public double GetSumOfPlastic()
        {
            return this.Plastic;
        }

        public double GetSumOfValidMetal()
        {
            return this.Gold + this.Platinum + this.Silver;
        }
    }
}