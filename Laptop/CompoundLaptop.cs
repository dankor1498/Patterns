using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Laptop
{
    internal class CompoundLaptop : ILaptop
    {
        public string NameLaptop { get; private set; }
        public List<ILaptop> all = new List<ILaptop>();

        public CompoundLaptop(string nameLaptop)
        {
            NameLaptop = nameLaptop;
        }

        public CompoundLaptop() { }

        public void AddComponent(ILaptop laptop)
        {
            all.Add(laptop);
        }

        public double GetSumOfPlastic()
        {
            double sum = 0.0;
            foreach (var item in all)
            {
                sum += item.GetSumOfPlastic();
            }
            return sum;
        }

        public double GetSumOfValidMetal()
        {
            double sum = 0.0;
            foreach (var item in all)
            {
                sum += item.GetSumOfValidMetal();
            }
            return sum;
        }

        public void SerializeLaptop()
        {
            //XmlSerializer formatter = new XmlSerializer(typeof(Person));

            //using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, person);

            //    Console.WriteLine("Объект сериализован");
            //}
        }
    }
}