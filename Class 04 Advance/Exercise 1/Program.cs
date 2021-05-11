using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {

            DogShelter.PrintAll();

            foreach (Dog dog in DogShelter.Dogs)
            {
                Console.WriteLine(Dog.Validate(dog.Id, dog.Name, dog.Color));
            }

        }
    }
}
