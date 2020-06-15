using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Laptop
{
    [Serializable]
    [XmlInclude(typeof(Keyboard))]
    [XmlInclude(typeof(Screen))]
    [XmlInclude(typeof(Touchpad))]
    [XmlInclude(typeof(Cooler))]
    [XmlInclude(typeof(CPU))]
    [XmlInclude(typeof(RAM))]
    [XmlInclude(typeof(VideoCard))]
    [XmlInclude(typeof(CompoundInsides))]
    [XmlInclude(typeof(CompoundLaptop))]
    [XmlInclude(typeof(CompoundMotherboard))]
    [XmlInclude(typeof(CompoundBody))]
    public abstract class AbstracComponent
    {
        public string Name { get; set; }

        public AbstracComponent(string name)
        {
            Name = name;
        }

        public AbstracComponent()
        {
        }

        public abstract double GetSumOfValidMetal();

        public abstract double GetSumOfPlastic();

        public abstract List<AbstracComponent> GetItems();

        public abstract double Accept(IVisitor visitor);
    }
}