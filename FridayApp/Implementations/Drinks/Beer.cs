using FridayApp.Interfaces;

namespace FridayApp.Implementations.Drinks
{
    public class Beer : IDrink
    {
        public string GetDrinkName()
        {
            return "Hoegaarden";
        }
    }
}
