using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Drawing;
using System.IO.Compression;
using System;
using Tavern;
using Heroes;
using Bobolink.Abstract;
using Bobolink.Service;
using Bobolink.Interfaces;

namespace NeverLand

{
    class Program
    {
        static void Main(string[] args)
        {

            // TODO: Создать Repository Pattern
            // TODO: Добавить базу данных
            // TODO: Подумать о паттернах
            // TODO: Добавить сервисы чатов

            // Для Кексика
            // TODO: Логика выбора героя, чтобы пользователь сам выбрать героя
            // Продумать что можеть делать герой
            // Продумай в начала, два режима, первый можно самому выбрать героя, второй рандомно назначается
            #region

            Hero hero = new Hero(
                "Azrael",
                "Black Knight",
                1000);
            hero.Description = "Crusader of darkness";

            Hero hero1 = new Hero(
                "Hawk",
                "Rogue",
                1000);
            hero1.Description = "Dodger";

            Hero hero2 = new Hero(
                "Zick",
                "Paladin",
                1000);
            hero2.Description = "Warrior of Light and justice";

            Console.WriteLine($"Greetings freedom soul. Choose your hero's body:\n");

            Hero[] heroes = new Hero[]{
            hero,
            hero1,
            hero2
            };

            for (int i = 0; i < heroes.Length; i++)
            {
                Console.WriteLine($"Hero{i + 1}: {heroes[i].HeroClass}. {heroes[i].Description}");
            };

            string change = Console.ReadLine();
            int chan = Convert.ToInt32(change);
            if (chan == 1)
            {
                Console.WriteLine($"Your choice is {hero.Name}. {hero.HeroClass}");
            }
            else if (chan == 2)
            {
                Console.WriteLine($"Your choice is {hero1.Name}. {hero1.HeroClass}");
            }
            else if (chan == 3)
            {
                Console.WriteLine($"Your choice is {hero2.Name}. {hero2.HeroClass}");
            }
            else
            {
                Console.WriteLine($"WTF!? Game is Over Man!");

            }

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

            #endregion
            ItemProduct[] item = new ItemProduct[] {
                sword1,
                health_elixir,
                plate,
                poison_elixir
            };

            Console.WriteLine($"\nMan in tavern say you:\"Listen to me. I have many interesting items.\"\n");

            IHeroActions heroActions = new HeroActions();

            heroActions.UseItemProduct(hero, poison_elixir, health_elixir);

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
                Console.WriteLine($"{item[1].Name}");
            }

        }

    }


}