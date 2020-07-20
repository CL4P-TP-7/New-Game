using Heroes;
using System;
using System.Collections.Generic;
using System.Text;


namespace Tavern
{
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }

    }
    class Weapon : Item
    {

        public string Hand { get; set; }

        public double Damage { get; set; }

        public Weapon(string name, double price, string hand, double damage) : base(name, price)
        {
            Hand = hand;
            Damage = damage;

        }


        public void WeaponAbility()
        {
            Console.WriteLine();
        }
    }
    class Armor : Item
    {

        public double Protection { get; set; }

        public Armor(string name, double price, double protection) : base(name, price)
        {
            Protection = protection;
        }
        public void WeaponAbility()
        {
            Console.WriteLine();
        }
    }
    class Elixir : Item
    {
        public Elixir(string name, double price) : base(name, price)
        {
        }
        

    }

}
