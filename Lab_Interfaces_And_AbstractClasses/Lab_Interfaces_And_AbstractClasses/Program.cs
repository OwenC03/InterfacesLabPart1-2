using System.Runtime.CompilerServices;

namespace Lab_Interfaces_And_AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input a Dogs Name Below");
            String dogsName = Console.ReadLine();
            Console.WriteLine("Please Input a Dogs Colour Below");
            String dogsColour = Console.ReadLine();
            Console.WriteLine("Please Input a Dogs Age Below");
            var dogsAge = Console.ReadLine();
            Dog dog = new Dog(dogsName, dogsColour, dogsAge);
            dog.Eat();
    
            Console.WriteLine("Please Input a Cats Name Below");
            String catsName = Console.ReadLine();
            Console.WriteLine("Please Input a Cats Colour Below");
            String catsColour = Console.ReadLine();
            Console.WriteLine("Please Input a Cats Age Below");
            var catsAge = Console.ReadLine();
            Cat cat = new Cat(catsName, catsColour, catsAge);
            cat.Eat();

        }
    }
    abstract class Animal
    {
        public String Name { get ; set ; }
        public String Colour { get; set; }
        public int Age { get; set; }

        public Animal(string name, string colour, string age)
        {
            Name = name;
            Colour = colour;
            
            if(int.TryParse(age, out int parsedAge))
            {
                Age = parsedAge;
            }
            else
            {
                Console.WriteLine("Invalid input for age. Defaulting to 0");
                Age = 0;
            }
        }

        public abstract void Eat();

    }
    class Dog : Animal 
    {
        public Dog(string name, string colour, string age) : base(name, colour, age)
        {
            Console.WriteLine(name + " is a " + colour + " dog and is " + age + " years old");
        } 
        public override void Eat()
        {
            Console.WriteLine("Dogs Eat Meat");
        }
    }
    class Cat : Animal
    {
        public Cat(string name, string colour, string age) : base(name, colour, age)
        {
            Console.WriteLine(name + " is a " + colour + " cat and is " + age + " years old");
        }
        public override void Eat()
        {
            Console.WriteLine("Cats Eat Mice");
        }
    }
}
