using System;

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