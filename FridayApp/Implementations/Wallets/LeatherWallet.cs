using FridayApp.Interfaces;

namespace FridayApp.Implementations.Wallets
{
    internal class LeatherWallet : IWallet
    {
        private readonly IMoney _money;

        public LeatherWallet(IMoney money)
        {
            _money = money;
        }

        public string GetWalletDetails()
        {
            var moneyDetails = $"I have {_money.Value} {_money.Currency} in my leather wallet.";
            return moneyDetails;
        }
    }
}