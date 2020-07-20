using Bobolink.Abstract;
using Bobolink.Interfaces;
using Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bobolink.Service
{
    public class HeroActions: IHeroActions
    {
        public void UseItemProduct(Hero hero, ItemProduct product)
        {
            product.Run(hero);
        }
    }
}
