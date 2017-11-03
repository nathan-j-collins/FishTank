namespace FishTank
{
    public class BabelFish : IFish
    {
        public string Name { get; }
        public double AmountOfFoodRequiredInGrams { get; }

        public BabelFish(string name)
        {
            AmountOfFoodRequiredInGrams = 0.3;
            Name = name;
        }
    }
}