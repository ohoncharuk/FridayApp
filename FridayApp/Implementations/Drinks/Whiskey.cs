using FridayApp.Interfaces;

namespace FridayApp.Implementations.Drinks
{
    public class Whiskey : IDrink
    {
        public string GetDrinkName()
        {
            return "Jack Daniel's";
        }
    }
}
