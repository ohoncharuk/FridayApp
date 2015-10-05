using System;
using FridayApp.Interfaces;

namespace FridayApp.Implementations.Dudes
{
    public class Tom : IDude
    {
        private readonly IDrink _drink;
        private readonly IWallet _wallet;

        public Tom(IDrink service, IWallet wallet)
        {
            _drink = service;
            _wallet = wallet;
        }

        public void ProposeToDrink()
        {
            Console.WriteLine($"My name is Tom, let's go to have a glass of {_drink.GetDrinkName()}.");

            Console.WriteLine(_wallet.GetWalletDetails());
        }
    }
}
