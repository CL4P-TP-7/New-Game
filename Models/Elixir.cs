using Bobolink.Abstract;
using Heroes;

namespace Tavern
{
    class Elixir : ItemProduct
    {
        public Elixir(string name, decimal price) : base(name, price)
        {
        }

        public override void Run(Hero hero)
        {
            System.Console.WriteLine("Cure");
        }
    }

}
