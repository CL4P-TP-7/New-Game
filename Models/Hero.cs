using Bobolink.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Tavern;

namespace Heroes
{
    public class Hero
    {
        public string Name { get; private set; }
        public string HeroClass { get; private set; }
        public decimal Gold { get; private set; }
        public string Description { get; set; }
        public decimal HP { get; set; }
        
        public object InHand 
        {  
            
            set 
            {
                Weapon weapon = new Weapon("", 0, "", 0);
            }
        }  

        public Hero(string name, string heroclass, decimal gold, decimal hp)
        {
            Name = name;
            HeroClass = heroclass;
            Gold = gold;
            HP = hp;
        }


        public virtual void Ability()
        {
            Console.WriteLine($"{HeroClass} применяет навык класса");
        }

        public void BuyItem(ItemProduct product)
        {
            Gold -= product.Price;
        }

        
        public void Atack()
        {

        }
    }


}
