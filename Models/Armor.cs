using Bobolink.Abstract;
using Bobolink.Interfaces;
using Heroes;
using System;


namespace Tavern
{
    class Armor : ItemProduct
    {
        public double Protection { get; set; }

        public Armor(string name, decimal price, double protection): base(name, price)
        {
            Protection = protection;
        }

        public override void Run(Creature hero)
        {
            
        }
    }

    
}
