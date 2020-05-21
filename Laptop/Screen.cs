namespace Laptop
{
    public class Screen : AbstractLaptop
    {
        public Screen()
        {
        }

        public Screen(string name, double glass, double platium) : base(name)
        {
            Platinum = platium;
            Glass = glass;
        }

        public double Platinum { get; set; }
        public double Glass { get; set; }

        public override double GetSumOfPlastic()
        {
            return 0.0;
        }

        public override double GetSumOfValidMetal()
        {
            return this.Platinum;
        }
    }
}