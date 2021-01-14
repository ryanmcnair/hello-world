using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var nameInput = Console.ReadLine();

            Console.WriteLine("Pick your greeting, Southern, Hawaiian or Surfer.");
            var greeting = Console.ReadLine();

            if (greeting == "Surfer")
            {
                Console.WriteLine($"Far out, {nameInput}");
            }
            else if (greeting == "Hawaiian")
            {
                Console.WriteLine($"Aloha, {nameInput}");
            }
            else
            {
                Console.WriteLine($"Howdy Partner, {nameInput}");
            }

            Console.WriteLine($"What's your favorite color, {nameInput}?");
            var colorInput = Console.ReadLine();

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };
            var randomAnimal = new Random();
            int index = randomAnimal.Next(animals.Length);

            Console.WriteLine($"Would you like a {colorInput} {animals[index]}?");

            var stringThing = new StringBuilder();
            Console.WriteLine("Please enter 4 random letters");
            var randomLetters = Console.ReadLine();

           for (int x = 0; x < randomLetters.Length; x++)
            {
                stringThing.Append(Char.ToUpper(randomLetters[x]));
                for (int y = 0; y < x; y++)
                {
                    stringThing.Append(Char.ToLower(randomLetters[x]));
                }
                if (x != randomLetters.Length - 1) stringThing.Append("-");
            }

            Console.WriteLine(stringThing);


            
        }
    }
}
