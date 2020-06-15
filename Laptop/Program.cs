using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Laptop
{
    internal class Program
    {
        private static CompoundLaptop CreateLaptop()
        {
            CompoundLaptop laptop = new CompoundLaptop("ASUS fx 505g");
            laptop.AddComponent(new CompoundBody("ASUS Body",
                                                 new Keyboard("ASUS keyboard", 0.152, 125.5),
                                                 new Screen("ASUS screen", 0.252, 0.411),
                                                 new Touchpad("ASUS touchpad", 0.147, 0.111, 54.9)));
            laptop.AddComponent(new CompoundInsides("ASUS Insides",
                                                    new CompoundMotherboard(
                                                        "ASUS Motherboard",
                                                        new RAM("ASUS RAM", 0.33, 0.425, 1.111, 5.25),
                                                        new CPU("ASUS CPU", 1.252, 2.131, 0.511, 0.0),
                                                        new VideoCard("ASUS video card", 0.152, 0.231, 0.311, 50.2)),
                                                    new Cooler("ASUS cooler", 0.153, 0.147, 0.111)));
            return laptop;
        }

        private static void SerializeLaptop(string path, CompoundLaptop laptop)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(CompoundLaptop));

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, laptop);
                    Console.WriteLine("\nОб'єкт успiшно серiалiзовано до " + path);
                }
            }
            catch
            {
                Console.WriteLine("\nCерiалiзацiя завершилась невдало.");
            }
        }

        private static void GetLINQPlastic(CompoundLaptop laptop)
        {
            Console.WriteLine("Деталi що мiстять пластик: ");
            var result = from item in laptop.GetItems()
                         let sum = item.GetSumOfPlastic()
                         where sum != 0.0
                         orderby sum
                         select new { Name = item.Name, Weight = sum };
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Weight} грамiв");
            }
        }

        private static void Main(string[] args)
        {
            CompoundLaptop laptop = CreateLaptop();
            Console.WriteLine($"Ноутбук {laptop.Name}:\n");

            Console.WriteLine("Чистий Composite: ");
            Console.WriteLine($"Цiнних металiв - {laptop.GetSumOfValidMetal():f2} грамiв\n");

            Console.WriteLine("Composite + Visitor: ");
            Console.WriteLine($"Цiнних металiв - {laptop.Accept(new ValidMetalVisitor()):f2} грамiв\n");


            //foreach (var item in laptop.GetItems())
            //{
            //    Console.WriteLine(item.Name);
            //}

            GetLINQPlastic(laptop);            
            SerializeLaptop(@"E:\Documents\GitHub\Patterns\Laptop\xml\laptop.xml", laptop);
        }
    }
}