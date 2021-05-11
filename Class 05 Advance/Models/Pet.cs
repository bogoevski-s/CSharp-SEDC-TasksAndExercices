using System;
using System.Collections.Generic;
namespace Models
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public PetType Type { get; set; }
        public int Age { set; get; }

        public Pet(string name, PetType type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }
        public abstract string PrintInfo();

    }
}
