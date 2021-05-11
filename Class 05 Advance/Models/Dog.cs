using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }

        public string FavFood { get; set; }

        public Dog(string name, PetType type, int age ,bool isGoodBoy, string favouriteFood) : base ( name,  type,  age)
        {
            GoodBoy = isGoodBoy;
            FavFood = favouriteFood;
        }
        public override string PrintInfo()
        {
            string goodBoy = GoodBoy ? "Good Boy" : "Not a good boy";
            return $"{Type} {Name} is a {goodBoy} and his favourite food is {FavFood}";
        }
    }
}
