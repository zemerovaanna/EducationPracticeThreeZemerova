using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    internal class Warehouse
    {
        List<Chair> ChairList;

        public Warehouse()
        {
            ChairList = new List<Chair>();
        }

        public void AddChair(Chair chair)
        {
            ChairList.Add(chair);
        }

        public bool CheckContainsChair(string chairname)
        {
            bool NotFound = true;

            foreach (Chair chair in ChairList)
            {
                if (chair.Name.Contains(chairname))
                {
                    NotFound = false;
                    break;
                }
            }

            return NotFound;
        }

        public List<Chair> GetChair() { return ChairList; }

        public List<Chair> SearchChairPrice(Warehouse warehouse, string chairprice)
        {
            bool search = false;

            List<Chair> searchresults = new List<Chair>();

            foreach (Chair chair in warehouse.GetChair())
            {
                if (Convert.ToString(chair.Price).Contains(chairprice))
                {
                    searchresults.Add(chair);
                    search = true;
                }
            }

            if (search == false)
            {
                MessageBox.Show("Не найдено.");
            }

            return searchresults;
        }

        public List<Chair> SearchChairName(Warehouse warehouse, string chairname)
        {
            bool search = false;

            List<Chair> searchresults = new List<Chair>();

            foreach (Chair chair in warehouse.GetChair())
            {
                if (chair.Name.Contains(chairname))
                {
                    searchresults.Add(chair);
                    search = true;
                }
            }

            if (search == false)
            {
                MessageBox.Show("Не найдено.");
            }

            return searchresults;
        }

        public void RemoveChair(Warehouse warehouse, int index)
        {
            ChairList.RemoveAt(index);
        }
    }
}