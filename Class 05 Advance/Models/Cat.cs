using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }
        public Cat(string name, PetType type, int age, bool lazy, int livesLeft) : base (name, type, age)
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
        }

        public override string PrintInfo()
        {
            string isLazy = Lazy ? "Lazzyyy" : "not Lazy";
            return $"{Type} {Name} is {isLazy} and has {LivesLeft} lives left";
        }
    }
}
