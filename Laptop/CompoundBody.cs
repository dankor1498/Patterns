using System;
using System.Collections.Generic;

namespace Laptop
{
    [Serializable]
    public class CompoundBody : AbstractLaptop
    {
        public AbstractLaptop[] components;

        public CompoundBody()
        {
        }

        public CompoundBody(string name, Keyboard keyboard, Screen screen, Touchpad touchpad) : base(name)
        {
            components = new AbstractLaptop[3] { keyboard, screen, touchpad };
        }

        public override double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override List<AbstractLaptop> GetItems()
        {
            List<AbstractLaptop> abstractLaptops = new List<AbstractLaptop>();
            foreach (var item in components)
            {
                abstractLaptops.AddRange(item.GetItems());
            }
            return abstractLaptops;
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