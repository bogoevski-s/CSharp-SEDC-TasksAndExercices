using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PetStore<T> where T : Pet
    {
        public string Name { get; set; }
        public List<T> PetStoreDb;

        public PetStore(string name)
        {
            Name = name;
            PetStoreDb = new List<T>();
        }
        public void PrintPets(List<T> list)
        {
            Console.WriteLine("Welcome to Pet Store \n");
            foreach (T pet in PetStoreDb)
            {
                Console.WriteLine($"Type: {pet.Type,-10}  Name: {pet.Name, -10} Age: {pet.Age, -10}");
            } 
        }
        public string BuyPet(List<T> list, string petName)
        {
            foreach (T pet in PetStoreDb)
            {
                if(pet.Name.ToLower() == petName.ToLower())
                {
                    PetStoreDb.Remove(pet);
                    return $"\n{pet.Type} {pet.Name} Successfuly Bought ";
                }
            }
            return $"\nPet with {petName} was not found";

        }
       
    }
}
