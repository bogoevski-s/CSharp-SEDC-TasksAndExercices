using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }
        public string Bark()
        {
            return $"Bark Bark";
        }

        public static string Validate(int id, string name, string color)
        {
            if(id < 0 || name.Length < 2 || color.Length < 1)
            {
                return $"Validatiin Fail for ID:{id}";
            }
            return $"Successful Validation";
        }

    }
}
