using FridayApp.Interfaces;

namespace FridayApp.Implementations.Wallets
{
    class BlueWallet : IWallet
    {
        private readonly IMoney _money;

        public BlueWallet(IMoney money)
        {
            _money = money;
        }

        public string GetWalletDetails()
        {
            var moneyDetails = $"I have {_money.Value} {_money.Currency} in my nice blue wallet.";
            return moneyDetails;
        }
    }
}
