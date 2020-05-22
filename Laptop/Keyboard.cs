using System;
using System.Collections.Generic;

namespace Laptop
{
    [Serializable]
    public class Keyboard : AbstractLaptop
    {
        public Keyboard()
        {
        }

        public Keyboard(string name, double gold, double plastic) : base(name)
        {
            Gold = gold;
            Plastic = plastic;
        }

        public double Gold { get; set; }

        public double Plastic { get; set; }

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
            return this.Plastic;
        }

        public override double GetSumOfValidMetal()
        {
            return this.Gold;
        }
    }
}