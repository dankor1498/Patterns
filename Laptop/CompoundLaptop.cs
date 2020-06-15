using System;
using System.Collections.Generic;

namespace Laptop
{
    [Serializable]
    public class CompoundLaptop : AbstracComponent
    {
        public List<AbstracComponent> components = new List<AbstracComponent>();

        public CompoundLaptop(string nameLaptop) : base(nameLaptop)
        {
        }

        public CompoundLaptop()
        {
        }

        public void AddComponent(AbstracComponent laptop)
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

        public override List<AbstracComponent> GetItems()
        {
            List<AbstracComponent> abstractLaptops = new List<AbstracComponent>();
            foreach (var item in components)
            {
                abstractLaptops.AddRange(item.GetItems());
            }
            return abstractLaptops;
        }
    }
}