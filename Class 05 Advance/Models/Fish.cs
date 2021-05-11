using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }
        public Fish(string name, PetType type, int age, string color, int size) : base (name, type, age)
        {
            Color = color;
            Size = size;
        }

        public override string PrintInfo()
        {
            return $"{Type} {Name} with {Color} color and size of {Size} ";
        }
    }
}
