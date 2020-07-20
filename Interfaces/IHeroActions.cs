using Bobolink.Abstract;
using Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bobolink.Interfaces
{
    public interface IHeroActions
    {
        void UseItemProduct(Hero hero, params ItemProduct[] products)
        {
            foreach(var product in products)
            {
                product.Run(hero);
            }
        }
    }
}
