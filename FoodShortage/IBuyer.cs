namespace FoodShortage
{
    public interface IBuyer : IPerson
    {
        public int Food { get;}
        void BuyFood();
    }
}