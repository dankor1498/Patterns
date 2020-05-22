using System;
using System.Collections.Generic;

namespace Laptop
{
    [Serializable]
    public class CompoundLaptop : AbstractLaptop
    {
        public List<AbstractLaptop> components = new List<AbstractLaptop>();

        public CompoundLaptop(string nameLaptop) : base(nameLaptop)
        {
        }

        public CompoundLaptop()
        {
        }

        public void AddComponent(AbstractLaptop laptop)
        {
            components.Add(laptop);
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
    }
}