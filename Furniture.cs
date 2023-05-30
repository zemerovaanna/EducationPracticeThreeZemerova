using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    internal class Furniture
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int CurrentYear { get; set; }
        public int ReleaseYear { get; set; }

        public Furniture() { }

        public Furniture(string name, int price, int count, int releaseyear)
        {
            Name = name;
            Price = price;
            Count = count;
            CurrentYear = DateTime.Now.Year;
            ReleaseYear = releaseyear;
        }

        virtual public string GetInformation()
        {
            return $"{Name};{Price};{Count};{ReleaseYear};{FurnitureQuality()}";
        }

        virtual public string ToSave()
        {
            return $"{Name};{Price};{Count};{ReleaseYear}";
        }

        public double FurnitureQuality()
        {
            return Price / Count;
        }
    }
}