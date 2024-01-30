namespace Lab_InterfacesAndAbstractClassesPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates the 'animals' list using the IAnimals interface
            List<IAnimal> animals = new List<IAnimal>();
            
            // Functions to ask the user and create all the necessary variables for dogs.
            Console.WriteLine("Please Input a Dogs Name Below");
            String dogsName = Console.ReadLine();
            Console.WriteLine("Please Input a Dogs Colour Below");
            String dogsColour = Console.ReadLine();
            Console.Write("Please Input a Dogs Height in cm: ");
            var dogsHeight = Console.ReadLine();
            Console.WriteLine("Please Input a Dogs Age Below");
            var dogsAge = Console.ReadLine();
            Dog dog = new Dog(dogsName, dogsColour, dogsHeight, dogsAge);
            
            //Adds the most recent dog made to the animals list 
            animals.Add(dog);

            // calls the .Eat and .Cry functions in the dog specific areas to display whatever is said or 
            // if nothing it defaults or does nothing
            dog.Eat();
            dog.Cry();

            // Functions to ask the user and create all the necessary variables for cats
            Console.WriteLine("Please Input a Cats Name Below");
            String catsName = Console.ReadLine();
            Console.WriteLine("Please Input a Cats Colour Below");
            String catsColour = Console.ReadLine();
            Console.WriteLine("Please Input a Cats Height in cm Below");
            var catsHeight = Console.ReadLine();
            Console.WriteLine("Please Input a Cats Age Below");
            var catsAge = Console.ReadLine();
            Cat cat = new Cat(catsName, catsColour,catsHeight, catsAge);
           
            // adds the most recent cat to the animals list
            animals.Add(cat); 

            // calls the .Eat and .Cry functions in the cat specific areas to display whatever is said or 
            // if nothing it defaults or does nothing
            cat.Eat();
            cat.Cry();

            // Writes the Names of the Animals in the list
            Console.WriteLine("Name of Animals: ");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
    // creates the interface and names it IAnimals
    interface IAnimal
    {
        // Sets the variables to either strings or ints based off what to expect and sets getters/setters, 
        // also setting up the Eat and Cry default functions 
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }


        void Eat();

        string Cry();
    }

    class Dog : IAnimal
    { 
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }

        public Dog(string name, string colour, string height, string age) 
        {
            Name = name;
            Colour = colour;
            if (int.TryParse(height, out int parsedHeight))
            {
                Height = parsedHeight;
            }
            else
            {
                Console.WriteLine("Invalid input for Height. Defaulting to 0");
                Height = 0;
            }
            
            if (int.TryParse(age, out int parsedAge))
            {
                Age = parsedAge;
            }
            else
            {
                Console.WriteLine("Invalid input for Age. Defaulting to 0");
                Age = 0;
            }
            Console.WriteLine(name + " is a " + colour + " dog and is " + height + "cm tall while being " + age + " years old");
        }
        public void Eat()
        {
            Console.WriteLine( "Dogs Eat Meat");
        }
        public string Cry()
        {
            return "Bark";
        }
        
    }
    class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }

        public Cat(string name, string colour, string height, string age) 
        {
            Name = name; 
            Colour = colour;
            
            if (int.TryParse(height, out int parsedHeight))
            {
                Height = parsedHeight;
            }
            else
            {
                Console.WriteLine("Invalid input for Height. Defaulting to 0");
                Height = 0;
            }

            if (int.TryParse(age, out int parsedAge))
            {
                Age = parsedAge;
            }
            else
            {
                Console.WriteLine("Invalid input for Age. Defaulting to 0");
                Age = 0;
            }
            Console.WriteLine(name + " is a " + colour + " dog and is " + height + " tall while being " + age + " years old");
        }
        public void Eat()
        {
            Console.WriteLine("Cats Like to eat Mice");
        }
        public string Cry()
        {
            return "Meow";
        }

    }
}
