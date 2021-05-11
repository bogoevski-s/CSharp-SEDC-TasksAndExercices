using System;
using Models;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {

            PetStore<Pet> petStore = new PetStore<Pet>("Snoop Dogs");

            Dog rex = new Dog("Rex", PetType.Dog, 7, true, "Pasta");
            Dog max = new Dog("Max", PetType.Dog, 12, false, "Beef");
            Dog snoop = new Dog("Snoop", PetType.Dog, 3, true, "Steak");

            Cat tom = new Cat("Tom", PetType.Cat, 2, false, 1);
            Cat blacky = new Cat("Blacky", PetType.Cat, 5, true, 9);
            Cat catly = new Cat("Catlyin", PetType.Cat, 7, false, 9);

            Fish fish1 = new Fish("Nemo", PetType.Fish, 1, "Orange", 10);
            Fish fish2 = new Fish("Sharky", PetType.Fish, 2, "Greay", 50);
            Fish fish3 = new Fish("Swordfish", PetType.Fish, 10, "Orange", 65);

            petStore.PetStoreDb.Add(rex);
            petStore.PetStoreDb.Add(tom);
            petStore.PetStoreDb.Add(max);
            petStore.PetStoreDb.Add(fish1);
            petStore.PetStoreDb.Add(snoop);
            petStore.PetStoreDb.Add(blacky);
            petStore.PetStoreDb.Add(fish3);
            petStore.PetStoreDb.Add(fish2);
            petStore.PetStoreDb.Add(catly);

            petStore.PrintPets(petStore.PetStoreDb);

            Console.WriteLine("\nEnter name of pet to buy:");
            string buyInput = Console.ReadLine();
            Console.WriteLine(petStore.BuyPet(petStore.PetStoreDb, buyInput)); 

            foreach(Pet pet in petStore.PetStoreDb)
            {
                Console.WriteLine(pet.PrintInfo());
            }

        }
    }
}
