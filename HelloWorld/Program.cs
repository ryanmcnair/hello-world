using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine($"The last four characters of your password are: {lastFour}");
            }
            else
            {
                Console.WriteLine("Not long enough.");
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
                    Console.WriteLine("Nope. I quit.");
                }
            }
            //Validator
            //Email Validator
            Console.WriteLine("Please enter a valid email address");
            var emailInput = Console.ReadLine();
            char[] emailCharacters = emailInput.ToCharArray();
            int atCount = 0;
            int dotCount = 0;

            foreach (var ch in emailCharacters)
            {
                if (ch == '@')
                {
                    atCount++;
                }
                else if (ch == '.')
                {
                    dotCount++;
                }
            }
            if (atCount > 1 || dotCount < 1)
            {
                Console.WriteLine("Not a valid email address");
            }
            else
            {
                Console.WriteLine("Your email address is valid");
            }

            //Phone Number
            Console.WriteLine("Please enter your phone number, including area code");
            var phoneNumberInput = Console.ReadLine();
            var removeCharacters = string.Join("", phoneNumberInput.Split('(', ')', '-', '.', ' '));
            string checkForFives = removeCharacters.Substring(0, 2);
            //int stringToNumbers = Int32.Parse(removeCharacters);
            var checkForDigits = Char.IsDigit(removeCharacters, 10);

            if (phoneNumberInput.Length > 13 || phoneNumberInput.Length < 10)
            {
                Console.WriteLine("Not a valid number");
            }
            else if (checkForFives.Contains("555"))
            {
                Console.WriteLine("Not a valid number");
            }
            else if (checkForDigits == false)
            {
                Console.WriteLine("Not a valid number");
            }
            else
            {
                Console.WriteLine($"Your number is ");
            }



            //PIN Number
            Console.WriteLine("Please enter a PIN code between 4 and 8 digits");
            int pinNumber;
            string pinNumberInput = Console.ReadLine();
            if (!int.TryParse(pinNumberInput, out pinNumber))
            {
                Console.WriteLine("Number values only");
            }
            else if (pinNumber < 1000)
            {
                Console.WriteLine("Too short");
            }
            else if (pinNumber > 99999999)
            {
                Console.WriteLine("Too long");
            }
            else
            {
                Console.WriteLine("Your PIN Number is recorded");
            }
            

            //Calculator Exercise
            Console.WriteLine("Do you want to add, multiply, square or average?");
            var calculatorInput = Console.ReadLine();
            Console.WriteLine("Please input 3 numbers like this: 1,2,3");
            var numberInput = Console.ReadLine();
            var numberSplit = numberInput.Split(",");
            var a = 0;
            var b = 0;
            var c = 0;
            var counter = 0;
            foreach (var number in numberSplit)
            {
                int stringToNumber = Int32.Parse(number);

                if (counter == 0)
                {
                    a += stringToNumber;
                    counter++;
                }
                else if (counter == 1)
                {
                    b += stringToNumber;
                    counter++;
                }
                else if (counter == 2)
                {
                    c += stringToNumber;
                    counter++;
                }
            }

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
            else if (calculatorInput == "average")
            {
                var average = $"The average of your numbers is {a + b + c / 3}";
                Console.WriteLine(average);
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
