   using System;

namespace Week6Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] superHeroes = { "Batman", "Santa", "Spongebob", "Thor", "Harry Potter" };
            string[] superVillains = { "Godzilla", "Voldemort", "Grinch", "Darth Vader", "T-1000" };
            string[] weapon = { "banana", "fork", "keyboard", "purse", "jar of mud" };

            Random rnd = new Random();
            int randomHeroes = rnd.Next(1, superHeroes.Length);
            int randomVillains = rnd.Next(1, superVillains.Length);
            int randomWeapon = rnd.Next(1, weapon.Length);
            Console.WriteLine($"{superHeroes[randomHeroes]} will fight {superVillains[randomVillains]} with a {weapon[randomWeapon]}.");

        }
    }
}
