using System.Collections.Generic;

namespace FishTank
{
    public class Tank
    {
        public List<IFish> Fish;

        public Tank()
        {
            Fish = new List<IFish>();
        }

        public void AddFish(IFish fish)
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
