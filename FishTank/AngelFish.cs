namespace FishTank
{
    public class AngelFish : IFish
    {
        public string Name { get; }
        public double AmountOfFoodRequiredInGrams { get; }

        public AngelFish(string name)
        {
            AmountOfFoodRequiredInGrams = 0.2;
            Name = name;
        }
    }
}
