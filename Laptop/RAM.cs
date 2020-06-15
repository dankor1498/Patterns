using System;
using System.Collections.Generic;

namespace Laptop
{
    [Serializable]
    public class RAM : AbstracComponent
    {
        public RAM()
        {
        }

        public RAM(string name, double gold, double silver, double platinum, double plastic) : base(name)
        {
            Silver = silver;
            Gold = gold;
            Platinum = platinum;
            Plastic = plastic;
        }

        public double Silver { get; set; }
        public double Gold { get; set; }
        public double Platinum { get; set; }
        public double Plastic { get; set; }

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
            return this.Plastic;
        }

        public override double GetSumOfValidMetal()
        {
            return this.Gold + this.Platinum + this.Silver;
        }
    }
}