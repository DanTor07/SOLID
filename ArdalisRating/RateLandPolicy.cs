using System;

namespace ArdalisRating
{
    public class RateLandPolicy
    {
        public static decimal CalculateRating(Policy policy)
        {
            Console.WriteLine("Rating LAND policy...");
            Console.WriteLine("Validating policy.");

            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                Console.WriteLine("Land policy must specify Bond Amount and Valuation.");
                return 0m;
            }

            if (policy.BondAmount < 0.8m * policy.Valuation)
            {
                Console.WriteLine("Insufficient bond amount.");
                return 0m;
            }

            return policy.BondAmount * 0.05m;
        }
    }
}