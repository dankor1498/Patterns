using System;
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
    public abstract class AbstractLaptop
    {
        public string Name { get; set; }

        public AbstractLaptop(string name)
        {
            Name = name;
        }

        public AbstractLaptop()
        {
        }

        public abstract double GetSumOfValidMetal();

        public abstract double GetSumOfPlastic();
    }
}