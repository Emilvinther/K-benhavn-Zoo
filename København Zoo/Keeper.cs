using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food;
using Animals;

namespace Employee
{
    internal class Keeper
    {
        // valueables
        private string _name;
        private int _id;
        private Random random = new Random();
        private List<int> keeperid = new List<int>();


        // properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        // Constructor
        public Keeper(string name)
        {
            _name = name;
            _id = GetMemberID();

        }

        // Gets a zookeeper ID
        private int GetMemberID()
        {
            int temp = 0;

            temp = random.Next(0,100);
            while (keeperid.Contains(temp))
            {
                temp = random.Next(0,100);
            }

            return temp;

        }
    }
}
