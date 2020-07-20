using System;
using System.Collections.Generic;
using System.Text;
using Tavern;

namespace Heroes
{
    class Hero
    {
        public string Name { get; private set; }
        public string HeroClass { get; private set; }
        public double Gold { get; private set; }

        public Hero (string name, string heroclass, double gold)
        {
            Name = name;
            HeroClass = heroclass;
            Gold = gold;
        }

        public virtual void Ability()
        {
            Console.WriteLine($"{HeroClass} применяет навык класса");
        }

        public void UseElixir(Elixir elixir)
        {
            Console.WriteLine($"{HeroClass} выпивает {elixir.Name}");

        }

        public void BuyItem(Item product)
        {
            Gold -= product.Price;  
        }

    }
    
    
}
