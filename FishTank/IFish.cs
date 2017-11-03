using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    public interface IFish
    {
        string Name { get; }
        double AmountOfFoodRequiredInGrams { get; }
    }
}
