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

            //Герои
            #region HeroModels

            Creature hero1 = new Creature(
                "Азраэль",
                "Рыцарь смерти",
                1000,
                700);
            hero1.Description = "Восставший воин";

            Creature hero2 = new Creature(
                "Хок",
                "Головорез",
                1000,
                500);
            hero2.Description = "Ловкач";

            Creature hero3 = new Creature(
                "Зик",
                "Паладин",
                1000,
                800);
            hero3.Description = "Воин света";

            #endregion

            //выбор героя первого игрока
            #region CreateHero
            Console.WriteLine($"Приветствую, незнакомец. Кто ты?\n(выберите героя по номеру, либо любую другую цифру для рандомного выбора)\n");

            Creature[] heroes = new Creature[]{
            hero1,
            hero2,
            hero3
            };

            for (int i = 0; i < heroes.Length; i++)
            {
                Console.WriteLine($"Герой{i + 1}: {heroes[i].HeroClass}. {heroes[i].Description}");
            };

            Creature player1 = new Creature("", "", 0, 0);//создание игрока на которого навешиваются доп функции

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



            Console.WriteLine($"Ваш выбор:{player1.Name}. {player1.HeroClass}\nЗдоровье:{player1.HP}поинтов");
            Console.WriteLine($"Кошелек:{player1.Gold} золото");
            #endregion
             
            //модели оружия
            #region WeaponModels
            Weapon sword1 = new Weapon(
                "Большой меч",
                200,
                "Двуручное",
                120);

            Weapon daggers1 = new Weapon(
                "Кинжалы",
                150,
                "Двуручное",
                70);

            Weapon maul1 = new Weapon(
                "Гигантский Молот",
                250,
                "Двуручное",
                140);

            #endregion

            // Выбор оружия для первого игрока
            #region ChangeWepon

            ItemProduct[] weapons = new ItemProduct[] {
                sword1,
                daggers1,
                maul1,

            };

            Console.WriteLine($"\nПеред выходом на арену необходимо выбрать оружие:\n");


            for (int i = 0; i < weapons.Length; i++)
            {
                Console.WriteLine($"Item {i + 1}:{weapons[i].Name}" +
                    $"\n Price:{weapons[i].Price}\n");

            }
            Console.WriteLine($"\nВыберите экипировку\"\n");




            int chan2 = Int32.Parse(Console.ReadLine());

            if (chan2 == 1)
            {
                Console.WriteLine($"\nВыбран:{sword1.Name}\nУрон:{sword1.Damage}\n");
                player1.WeaponHero = (sword1.Name, sword1.Damage);
                player1.BuyItem(sword1);
                Console.WriteLine($"Золото 1-го игрока:{player1.Gold}\n");

            }
            if (chan2 == 2)
            {
                Console.WriteLine($"\nВыбран:{daggers1.Name}\nУрон:{daggers1.Damage}\n");
                player1.WeaponHero = (daggers1.Name, daggers1.Damage);
                player1.BuyItem(daggers1);
                Console.WriteLine($"Золото 1-го игрока:{player1.Gold}\n");

            }
            if (chan2 == 3)
            {
                Console.WriteLine($"\nВыбран:{maul1.Name}\nУрон:{maul1.Damage}\n");
                player1.WeaponHero = (maul1.Name, maul1.Damage);
                player1.BuyItem(maul1);
                Console.WriteLine($"Золото 1-го игрока:{player1.Gold}\n");

            }
            #endregion

            Console.WriteLine($"{player1.HeroClass} бьет {player1.WeaponHero.name} на {player1.WeaponHero.damage} урона");

            IHeroActions heroActions = new HeroActions();

            //игрок атакует другого персонажа
            player1.Atack(hero3);
            Console.WriteLine($"{hero3.HP}");


            #region Пригодится позже
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
            #endregion
        }

    }


}