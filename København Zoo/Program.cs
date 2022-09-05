using System;
using Food;
using Employee;
using HumanResources;
using Animals;

namespace København_Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instances of objects
            Keeper zookeeper = new Keeper("Carsten");
            Animal animal = new Animal(((Animal.AnimalRace)0), true);
            HR humananimal = new HR("Freja");

            // uses food dispenser
           FoodDispenser.Instance.GetFood("Zebra");

        }
    }
}
