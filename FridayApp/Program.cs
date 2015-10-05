using System;
using Autofac;
using FridayApp.Interfaces;

namespace FridayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var dude = scope.Resolve<IDude>();

                dude.ProposeToDrink();
            }
            
            Console.ReadKey();
        }
    }
}