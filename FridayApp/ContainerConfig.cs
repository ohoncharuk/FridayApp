using Autofac;
using FridayApp.Implementations.Drinks;
using FridayApp.Implementations.Dudes;
using FridayApp.Implementations.Money;
using FridayApp.Implementations.Wallets;
using FridayApp.Interfaces;

namespace FridayApp
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            
            //builder.RegisterType<Beer>().As<IDrink>();
            //builder.RegisterType<Tom>().As<IDude>();
            //builder.RegisterType<LeatherWallet>().As<IWallet>();
            //builder.RegisterType<Dollar>().As<IMoney>();

            //builder.RegisterType<Whiskey>().As<IDrink>();
            //builder.RegisterType<Mike>().As<IDude>();
            //builder.RegisterType<BlueWallet>().As<IWallet>();
            //builder.RegisterType<Euro>().As<IMoney>();

            builder.RegisterType<Beer>().As<IDrink>();
            builder.RegisterType<Mike>().As<IDude>();
            builder.RegisterType<LeatherWallet>().As<IWallet>();
            builder.RegisterType<Euro>().As<IMoney>();

            //builder.RegisterType<Whiskey>().As<IDrink>();
            //builder.RegisterType<Tom>().As<IDude>();
            //builder.RegisterType<BlueWallet>().As<IWallet>();
            //builder.RegisterType<Dollar>().As<IMoney>();
            
            return builder.Build();
        }
    }
}
