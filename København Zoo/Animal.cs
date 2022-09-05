using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Animal
    {
        // enum with animal pool
         public enum AnimalRace
         {
            Zebra,
            Tiger,
            Hippo
         }

        // Valueable
        private bool _gender;

        // Properties
        AnimalRace race
        {
            get { return race; }
            set { race = value; }
        }

        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        // Constructors
        public Animal(AnimalRace race, bool gender )
        {
            this.race = race;
            this._gender = gender;

        }

        // Method for Eating
        private string Eats()
        {
            return $"Eats";
        }

        // Method for Drinking
        private string Drinks()
        {
            return $"Drinks";
        }
    }


    
}
