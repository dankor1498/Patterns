using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop
{
    public interface IVisitor
    {
        double Visit(CompoundLaptop compoundLaptop);
        double Visit(CompoundBody compoundBody);
        double Visit(CompoundInsides compoundInsides);
        double Visit(CompoundMotherboard compoundMotherboard);
        double Visit(Cooler cooler);
        double Visit(CPU cpu);
        double Visit(Keyboard keyboard);
        double Visit(RAM ram);
        double Visit(Screen screen);
        double Visit(Touchpad touchpad);
        double Visit(VideoCard videoCard);
    }
}
