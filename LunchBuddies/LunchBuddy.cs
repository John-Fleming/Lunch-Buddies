using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string FullName { get; }

        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = $"{firstName} {lastName}";
        }

        public void Eat()
        {
            var randomRestaurant = new Restaurant();
            Console.WriteLine($"{FullName} is at {randomRestaurant.Name}");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FullName} is eating {food} at the office");
        }

        public void Eat(List<LunchBuddy> companions)
        {
            var randomRestaurant = new Restaurant();
            Console.WriteLine($"{FullName} is at {randomRestaurant.Name} with:");

            foreach (var friend in companions)
            {
                Console.WriteLine(friend.FirstName);
            }
        }

        public void Eat(string food, List<LunchBuddy> companions)
        {
            var randomRestaurant = new Restaurant();
            Console.WriteLine($"{FullName} is eating {food} at {randomRestaurant.Name} with:");

            foreach (var friend in companions)
            {
                Console.WriteLine(friend.FirstName);
            }
        }
    }
}
