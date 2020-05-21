using System;

namespace Laptop
{
    public abstract class AbstractComponent
    {
        public string Name { get; private set; }
        public double Gold { get; private set; }
        public double Silver { get; private set; }
        public double Platinum { get; private set; }
        public double Plastic { get; private set; }
        public AbstractComponent(string name, double gold, double silver, double platium, double plastic)
        {
            Name = name;
            Gold = gold;
            Silver = silver;
            Platinum = platium;
            Plastic = plastic;
        }
    }
}