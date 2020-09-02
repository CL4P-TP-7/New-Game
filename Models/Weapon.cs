using Bobolink.Abstract;
using Heroes;
using System;


namespace Tavern
{
    public class Weapon : ItemProduct
    {

        public string Hand { get; set; }

        public decimal Damage { get; set; }

        public Weapon(string name, decimal price, string hand, decimal damage) : base(name, price)
        {
            Hand = hand;
            Damage = damage;
        }

        public override void Run(Hero hero)
        {
            Console.WriteLine("Бум");
        }

        
    }

}
