namespace FishTank
{
    public class GoldFish : IFish
    {
        public string Name { get; }
        public double AmountOfFoodRequiredInGrams { get; }

        public GoldFish(string name)
        {
            AmountOfFoodRequiredInGrams = 0.1;
            Name = name;
        }
    }
}
