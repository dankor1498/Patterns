using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop
{
    public class ValidMetalVisitor : IVisitor
    {
        public ValidMetalVisitor()
        {
        }

        public double Visit(CompoundLaptop compoundLaptop)
        {
            return compoundLaptop.GetSumOfValidMetal();
        }

        public double Visit(CompoundBody compoundBody)
        {
            return compoundBody.GetSumOfValidMetal();
        }

        public double Visit(CompoundInsides compoundInsides)
        {
            return compoundInsides.GetSumOfValidMetal();
        }

        public double Visit(CompoundMotherboard compoundMotherboard)
        {
            return compoundMotherboard.GetSumOfValidMetal();
        }

        public double Visit(Cooler cooler)
        {
            return cooler.Silver;
        }

        public double Visit(CPU cpu)
        {
            return cpu.Gold + cpu.Platinum + cpu.Silver;
        }

        public double Visit(Keyboard keyboard)
        {
            return keyboard.Gold;
        }

        public double Visit(RAM ram)
        {
            return ram.Gold + ram.Platinum + ram.Silver;
        }

        public double Visit(Screen screen)
        {
            return screen.Platinum;
        }

        public double Visit(Touchpad touchpad)
        {
            return touchpad.Platinum + touchpad.Silver;
        }

        public double Visit(VideoCard videoCard)
        {
            return videoCard.Gold + videoCard.Platinum + videoCard.Silver;
        }
    }
}
