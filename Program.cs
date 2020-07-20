using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Drawing;
using System.IO.Compression;
using System;
using Tavern;
using Heroes;


namespace NeverLand

{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero(
                "Azrael",
                "Black Knight",
                1000);

            Weapon sword1 = new Weapon(
                "Slayer's Sword",
                250,
                "two-handed",
                120);

            Elixir health_elixir = new Elixir(
                "Health potion",
                50);

            Elixir poison_elixir = new Elixir(
                "Poison",
                50);

            Armor plate = new Armor(
                "Plate of darkness",
                500,
                50);

            Item[] item = new Item[] {
            sword1,
            health_elixir,
            plate,
            poison_elixir
            };

            Console.WriteLine($"\nMan in tavern say you:\"Listen to me. I have many interesting items.\"\n");
            for (int i = 0; i < item.Length; i++)
            {
                Console.WriteLine($"Item {i + 1}:{item[i].Name}" +
                    $"\n Price:{item[i].Price}\n");

            }
            Console.WriteLine($"\nMan in tavern say you:\"Please, choose... What would you like?\"\n");

            string str = Console.ReadLine();
            int num = Convert.ToInt32(str);
            if (num == 1)
            {

            }

        }

    }


}