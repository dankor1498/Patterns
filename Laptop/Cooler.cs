﻿using System;
using System.Collections.Generic;

namespace Laptop
{
    [Serializable]
    public class Cooler : AbstracComponent
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
            return this.Silver;
        }
    }
}