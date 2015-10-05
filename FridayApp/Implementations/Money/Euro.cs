using FridayApp.Interfaces;

namespace FridayApp.Implementations.Money
{
    public class Euro : IMoney
    {
        public string Currency { get; set; }
        public double Value { get; set; }

        public Euro()
        {
            Currency = "EUR";
            Value = 20;
        }
    }
}