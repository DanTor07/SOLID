using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating
{
    public class RateFloodPolicy
    {
        public static decimal CalculateRating(Policy policy)
        {
            Console.WriteLine("Validating Flood policy.");

            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                Console.WriteLine("Flood policy must specify Bond Amount and Valuation.");
                return 0m;
            }

            if (policy.ElevationAboveSeaLevelFeet <= 0)
            {
                Console.WriteLine("Flood policy is not available for elevations at or below sea level.");
                return 0m;
            }

            if (policy.BondAmount < 0.8m * policy.Valuation)
            {
                Console.WriteLine("Insufficient bond amount.");
                return 0m;
            }

            decimal multiple = 1.0m;
            if (policy.ElevationAboveSeaLevelFeet < 100)
            {
                multiple = 2.0m;
            }
            else if (policy.ElevationAboveSeaLevelFeet < 500)
            {
                multiple = 1.5m;
            }
            else if (policy.ElevationAboveSeaLevelFeet < 1000)
            {
                multiple = 1.1m;
            }

            return policy.BondAmount * 0.05m * multiple;
        }
    }
}


