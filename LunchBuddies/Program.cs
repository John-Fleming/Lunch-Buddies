using System;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var rest = new Restaurant();

            Console.WriteLine(rest.Restaurants);
            Console.WriteLine(rest.Name);

        }
    }
}
