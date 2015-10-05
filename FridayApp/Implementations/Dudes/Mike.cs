using System;
using FridayApp.Interfaces;

namespace FridayApp.Implementations.Dudes
{
    public class Mike : IDude
    {
        private readonly IDrink _drink;

        public Mike(IDrink service)
        {
            _drink = service;
        }

        public void ProposeToDrink()
        {
            Console.WriteLine($"I'm Mike. Would you like to drink {_drink.GetDrinkName()}?");
        }
    }
}