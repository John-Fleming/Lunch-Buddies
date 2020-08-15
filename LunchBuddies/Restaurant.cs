using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        public string Name { get; set; }

        public List<string> Restaurants { get; } = new List<string> { "Hattie B's", "ML Rose", "Burger Up", "Smiling Elephant" };

        public Restaurant()
        {
            var random = new Random();
            int index = random.Next(Restaurants.Count);
            Name = Restaurants[index];
        }
    }
}
