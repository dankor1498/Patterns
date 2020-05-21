namespace Laptop
{
    public class Touchpad : AbstractLaptop
    {
        public Touchpad()
        {
        }

        public Touchpad(string name, double silver, double platium, double plastic) : base(name)
        {
            Silver = silver;
            Platinum = platium;
            Plastic = plastic;
        }

        public double Silver { get; set; }
        public double Platinum { get; set; }
        public double Plastic { get; set; }

        public override double GetSumOfPlastic()
        {
            return this.Plastic;
        }

        public override double GetSumOfValidMetal()
        {
            return this.Platinum + this.Silver;
        }
    }
}