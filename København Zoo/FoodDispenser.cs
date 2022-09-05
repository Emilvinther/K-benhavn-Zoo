using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals;


namespace Food
{
    internal class FoodDispenser
    {
        // Valueables
        private string _food;
        // Valueable that can be null for simpleton
        private static FoodDispenser? instance = null;
       
        // Property
        public string Food
        {
            get { return _food; }
            private set { _food = value; }
        }

        // Private constructor for simpleton
        private FoodDispenser()
        {
            
        }
        // Simpleton property
        public static FoodDispenser Instance
        {
            get
            {
                instance = new FoodDispenser();
                return instance;
            }
        }

        // Checks animal vs the kind of food they eat
        public void GetFood(string animal)
        {
            if (animal == "Zebra")
            {
                _food = "Grass";
            }
            else if (animal == "Tiger")
            {
                _food = "Meat";
            }
            else if (animal == "Hippo")
            {
                _food = "Fruit";
            }
        }
    }
}
