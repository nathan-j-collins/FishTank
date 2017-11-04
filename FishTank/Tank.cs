using System.Collections.Generic;

namespace FishTank
{
    public class Tank
    {
        public List<Fish> Fish;

        public Tank()
        {
            Fish = new List<Fish>();
        }

        public void AddFish(Fish fish)
        {
            Fish.Add(fish);
        }

        public double Feed()
        {
            double result = 0.0;
            Fish.ForEach(f => result += f.AmountOfFoodRequiredInGrams);
            return result;
        }
    }
}
