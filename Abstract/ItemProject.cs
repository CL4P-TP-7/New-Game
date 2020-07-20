using Bobolink.Interfaces;
using Heroes;
using System.Security.Principal;

namespace Bobolink.Abstract
{
    public abstract class ItemProduct: IWeaponBehavior
    {
        protected ItemProduct(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }

        public abstract void Run(Hero hero);
    }
}