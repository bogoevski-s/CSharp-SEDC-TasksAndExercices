using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public static class DogShelter
    {
        public static List<Dog> Dogs { get; set; }
        static DogShelter()
        {
            Dogs = new List<Dog>
            {
                new Dog(1, "Rex", "Black And Brown"),
                new Dog(2, "Bucky", "Black"),
                new Dog(3, "Sharko", "Black And White"),
                new Dog(4, "Max", "")
            };
        }
        public static void PrintAll()
        {
            Console.WriteLine("\nPet Shelter\n");
            foreach(Dog dog in Dogs)
            {
                Console.WriteLine($"ID: {dog.Id,2}      Name : {dog.Name,8}      Color : {dog.Color,8}");
            }
            Console.WriteLine("\n\n");
        }
    }
}
