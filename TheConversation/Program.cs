using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheConversation
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // variables
            //
            string userName;
            string userAge;
            int userAgeInteger;

            //
            // enter conversation with user
            //
            Console.WriteLine("Hello!");
            Console.WriteLine("My name is John.");

            //
            // great the user and get their name
            //
            Console.WriteLine();
            Console.Write("What is your name? ");
            userName = Console.ReadLine();
            Console.WriteLine("It is nice to meet you " + userName + ".");
            //Console.WriteLine("It is nice to meet you {0}.", userName);
            //Console.WriteLine($"It is nice to meet you {userName}.");
            
            //
            // get user's age
            //
            Console.WriteLine();
            Console.Write("What is your age?");
            userAge = Console.ReadLine();
            Console.WriteLine($"Oh, your age is {userAge}.");
            userAgeInteger = int.Parse(userAge);

            Console.WriteLine("So, {0}, you are {1} years old.", userName, userAge);

            if (userAgeInteger >= 80)
            {
                Console.WriteLine("You are an old fart!");
            }
            else if (userAgeInteger >= 40)
            {
                Console.WriteLine("You must have great skin.");
            }
            else
            {
                Console.WriteLine("You are a spring chicken.");
            }

            if (userAgeInteger >= 20 && userAgeInteger <= 40)
            {
                Console.WriteLine("Millenial");
            }

            string userResponse;

            if (userResponse == "yes")
            {

            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
