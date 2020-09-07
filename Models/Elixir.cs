using Bobolink.Abstract;
using Heroes;

namespace Tavern
{
    class Elixir : ItemProduct
    {
        public Elixir(string name, decimal price) : base(name, price)
        {
        }

        public override void Run(Creature hero)
        {
            System.Console.WriteLine("Лечение");
        }
    }

}
