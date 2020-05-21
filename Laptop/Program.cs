using System;
using System.IO;
using System.Xml.Serialization;

namespace Laptop
{
    internal class Program
    {
        private static CompoundLaptop CreateLaptop()
        {
            CompoundLaptop laptop = new CompoundLaptop("ASUS fx 505g");
            laptop.AddComponent(new CompoundBody("ASUS Body",
                                                 new Keyboard("ASUS keyboard", 0.152, 0.231, 0.011, 125.5),
                                                 new Screen("ASUS screen", 0.252, 0.131, 0.411, 0.0),
                                                 new Touchpad("ASUS touchpad", 0.153, 0.147, 0.111, 54.9)));
            laptop.AddComponent(new CompoundInsides("ASUS Insides",
                                                    new CompoundMotherboard(
                                                        "ASUS Motherboard",
                                                        new RAM("ASUS RAM", 0.33, 0.425, 1.111, 5.25),
                                                        new CPU("ASUS CPU", 1.252, 2.131, 0.511, 0.0),
                                                        new VideoCard("ASUS Video card", 0.152, 0.231, 0.311, 50.2)),
                                                    new Cooler("ASUS cooler", 0.153, 0.147, 0.111, 0.0)));
            return laptop;
        }

        private static void Main(string[] args)
        {
            CompoundLaptop laptop = CreateLaptop();
            Console.WriteLine($"Ноутбук {laptop.NameLaptop}:");
            Console.WriteLine($"Пластику - {laptop.GetSumOfPlastic():f2} грамiв");
            Console.WriteLine($"Цiнних металiв - {laptop.GetSumOfValidMetal():f2} грамiв");            
        }
    }
}