using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee;

namespace HumanResources
{
    internal class HR
    {
        // valueables
        private string _name;
        private int _hrid;
        private Random random = new Random();
        private List<int> hrid = new List<int>();


        // Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Hrid
        {
            get { return _hrid; }
            private set { _hrid = value; }
        }

        public HR(string name)
        {
            _name = name;
            _hrid = GetHRID();

        }

        // Method that create a HR ID and checks if it exist, and creates a new one if it already exist on the list
        private int GetHRID()
        {
            int temp = 0;

            temp = random.Next(0, 100);
            while (hrid.Contains(temp))
            {
                temp = random.Next(0, 100);
            }

            return temp;

        }
    }
}
