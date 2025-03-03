namespace W02._2._1T07;

static class Program
{
    static void Main()
    {
        /*Create a List of Pets here:
         *- a Dog named Nugent
         *- a Cat named Steve
         *- a Goldfish named Brutus
         */

        List<Pet> johnPets = new List<Pet>
        {
            new Pet("Dog", "Nugent"),
            new Pet("Cat", "Steve"),
            new Pet("Goldfish", "Brutus")
        };

        Person john = new Person("John", johnPets);

        foreach (Pet pet in john.Pets)
        {
            Console.WriteLine($"{john.Name} has a {pet.WhatAmI} named {pet.Name}");
        }

    }
}

