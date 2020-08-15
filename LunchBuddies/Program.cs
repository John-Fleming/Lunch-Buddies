using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var john = new LunchBuddy("John", "Fleming");
            var anca = new LunchBuddy("Anca", "Simon");
            var liza = new LunchBuddy("Liza", "Star");
            var zac = new LunchBuddy("Zac", "Crumpton");


            var companions = new List<LunchBuddy>();
            companions.Add(anca);
            companions.Add(liza);
            companions.Add(zac);

            john.Eat();
            john.Eat("tacos");
            john.Eat(companions);
            john.Eat("tacos", companions);


        }
    }
}
