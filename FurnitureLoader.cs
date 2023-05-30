using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    internal class FurnitureLoader
    {
        public static void Load(Warehouse warehouse, string FileName)
        {
            if (File.Exists(FileName))
            {
                string[] note = File.ReadAllLines(FileName);

                foreach (string line in note)
                {
                    string[] components = line.Split(';');
                    if (components.Length == 5)
                    {
                        string name = components[0];
                        int price = int.Parse(components[1]);
                        int count = int.Parse(components[2]);
                        string material = components[3];
                        int releaseyear = int.Parse(components[4]);

                        Chair chair = new Chair(name, price, count, material, releaseyear);
                        warehouse.AddChair(chair);
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Save(Warehouse warehouse, string FileName)
        {
            StreamWriter streamwriter = new StreamWriter(FileName);

            foreach (Chair chair in warehouse.GetChair())
            {
                streamwriter.WriteLine(chair.ToSave());
            }

            streamwriter.Close();
        }
    }
}