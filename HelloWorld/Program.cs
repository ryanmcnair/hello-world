using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Validator
            //Mask Sensitive Information
            Console.WriteLine("Please enter a password that is 6 or more characters:");
            string sensitiveInfoToMask = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                sensitiveInfoToMask += key.KeyChar;
            }
            if (sensitiveInfoToMask.Length > 4)
            {
                string lastFour = sensitiveInfoToMask.Substring(sensitiveInfoToMask.Length - 4);
                Console.WriteLine($"The last four digits of your password are: {lastFour}");
            }
            else
            {
                Console.WriteLine("Not long enough dummy. Can't you count?");
                Console.WriteLine("Please enter a password that is 6 or more characters:");
                string newSensitiveInfoToMask = null;
                while (true)
                {
                    var key = System.Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                        break;
                    newSensitiveInfoToMask += key.KeyChar;
                }
                if (newSensitiveInfoToMask.Length > 4)
                {
                    string lastFour = newSensitiveInfoToMask.Substring(newSensitiveInfoToMask.Length - 4);
                    Console.WriteLine($"The last four digits of your password are: {lastFour}");
                }
                else
                {
                    Console.WriteLine("Go back to kindergarten. I quit.");
                }
            }
            


            //Calculator Exercise
            Console.WriteLine("Do you want to add, multiply, square or average?");
            var calculatorInput = Console.ReadLine();
            Console.WriteLine("Please input 3 numbers like this: 1,2,3");
            var numberInput = Console.ReadLine();
            var numberSplit = numberInput.Split(",");
            foreach (var number in numberSplit)
            {
                int stringToNumber = Int32.Parse(number);
                Console.WriteLine($"number: {stringToNumber}");
            }
          
            var a = 1;
            var b = 4;
            var c = 5;
            var average = a + b + c / 3;

            if (calculatorInput == "multiply")
            {
                var multiply = $"Your numbers multiplied together are {a * b * c}";
                Console.WriteLine(multiply);
            }
            else if (calculatorInput == "square")
            {
                var square = $"Your numbers squared are {a * a}, {b * b}, & {c * c}";
                Console.WriteLine(square);
            }
            else if (calculatorInput == "add")
            {
                var add = $"Your numbers added together total  {a + b + c}";
                Console.WriteLine(add);
            }

            //Hello World & Console Input
            Console.WriteLine("What is your name?");
            var nameInput = Console.ReadLine();

            Console.WriteLine("Pick your greeting: Southern, Hawaiian or Surfer.");
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

            //Letter Loops
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
