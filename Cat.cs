using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2LAB003
{
    public class Cat : IAnimal
    {

        public string Name { get; set; }
        public string Color { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        public Cat()
        {

        }

        public void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }

        public string Cry()
        {
            return "Meow!";
        }

        public override string ToString()
        {
            return $"\nCat information:\n" +
                $"Name: {Name}.\n" +
                $"Color: {Color}.\n" +
                $"Age: {Age}.\n" +
                $"Height: {Height}.";
        }
    }
}
