using FridayApp.Interfaces;

namespace FridayApp.Implementations.Money
{
    public class Dollar : IMoney
    {
        public string Currency { get; set; }
        public double Value { get; set; }

        public Dollar()
        {
            Currency = "USD";
            Value = 50;
        }
    }
}