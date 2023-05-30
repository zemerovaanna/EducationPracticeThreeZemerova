using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Warehouse
{
    internal class Chair : Furniture
    {
        public string Material { get; set; }

        public Chair(string name, int price, int count, string material, int releaseyear)
        {
            Name = name;
            Price = price;
            Count = count;
            Material = material;
            ReleaseYear = releaseyear;
        }

        public override string GetInformation()
        {
            return $"{Name};{Price};{Count};{Material};{ReleaseYear};{FurnitureQuality()};{ChairQuality()}";
        }

        public override string ToSave()
        {
            return $"{Name};{Price};{Count};{Material};{ReleaseYear}";
        }

        public double ChairQuality()
        {
            return FurnitureQuality() + 0.5 * (CurrentYear - ReleaseYear);
        }
    }
}