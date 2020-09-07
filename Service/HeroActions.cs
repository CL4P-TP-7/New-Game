using Bobolink.Abstract;
using Bobolink.Interfaces;
using Heroes;
using System;
using System.Collections.Generic;
using System.Text;
using Tavern;

namespace Bobolink.Service
{
    public class HeroActions: IHeroActions
    {
        public void Atack (Creature hero, Weapon weapon)
        {
            weapon.Run(hero);
        }
        public void UseItemProduct(Creature hero, ItemProduct product)
        {
            product.Run(hero);
        }
    }
}
