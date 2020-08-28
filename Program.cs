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
            // TODO: Логика выбора героя, чтобы пользователь сам выбрать героя +
            // Продумать что можеть делать герой 
            // Продумай в начала, два режима, первый можно самому выбрать героя, второй рандомно назначается +
            #region CreateHero

            Hero hero1 = new Hero(
                "Азраэль",
                "Рыцарь смерти",
                1000,
                700);
            hero1.Description = "Восставший воин";

            Hero hero2 = new Hero(
                "Хок",
                "Головорез",
                1000,
                500);
            hero2.Description = "Ловкач";

            Hero hero3 = new Hero(
                "Зик",
                "Паладин",
                1000,
                800);
            hero3.Description = "Воин света";



            Console.WriteLine($"Приветствую, незнакомец. Кто ты?\n(выберите героя по номеру, либо любую другую цифру для рандомного выбора)\n");

            Hero[] heroes = new Hero[]{
            hero1,
            hero2,
            hero3
            };

            for (int i = 0; i < heroes.Length; i++)
            {
                Console.WriteLine($"Герой{i + 1}: {heroes[i].HeroClass}. {heroes[i].Description}");
            };

            Hero player1 = new Hero("", "", 0,0);

            int chan = Int32.Parse(Console.ReadLine()); // упрощенный вариант для ввода чисел

            if (chan == 1)
            {
                player1 = hero1;
            }
            else if (chan == 2)
            {
                player1 = hero2;
            }
            else if (chan == 3)
            {
                player1 = hero3;
            }
            else
            {
                Console.WriteLine($"Рандомный выбор");
                
                Random rnd = new Random();
                chan = rnd.Next(1, 3);

                if (chan == 1)
                {
                    player1 = hero1;
                }
                else if (chan == 2)
                {
                    player1 = hero2;
                }
                else if (chan == 3)
                {
                    player1 = hero3;
                }
            }

            #endregion

            Console.WriteLine($"Ваш выбор:{player1.Name}. {player1.HeroClass}\nЗдоровье:{player1.HP}поинтов");
            Console.WriteLine($"Кошелек:{player1.Gold} золото");

            
            Weapon sword1 = new Weapon(
                "Большой меч",
                250,
                "Двуручное",
                120);

            Weapon dagger1 = new Weapon(
                "Кинжал",
                100,
                "Одноручный",
                50);

            Elixir health_elixir = new Elixir(
                "Эликсир здоровья",
                50);

            Elixir poison_elixir = new Elixir(
                "Эликсир яда",
                50);

            Armor plate = new Armor(
                "Полный доспех",
                500,
                50);

            
            

            ItemProduct[] item = new ItemProduct[] {
                sword1,
                dagger1,
                health_elixir,
                plate,
                poison_elixir
            };

            Console.WriteLine($"\nПеред выходом на арену необходимо выбрать экипировку:\n");

            IHeroActions heroActions = new HeroActions();

            heroActions.UseItemProduct(hero1, poison_elixir, health_elixir);

            for (int i = 0; i < item.Length; i++)
            {
                Console.WriteLine($"Item {i + 1}:{item[i].Name}" +
                    $"\n Price:{item[i].Price}\n");

            }
            Console.WriteLine($"\nВыберите экипировку\"\n");

            string str = Console.ReadLine();
            int num = Convert.ToInt32(str);
            if (num == 1)
            {
                Console.WriteLine($"{item[1].Name}");
            }

        }

    }


}