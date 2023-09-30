using System;

namespace ArdalisRating
{
    public class RateAutoPolicy
    {
        public static decimal CalculateRating(Policy policy)
        {
            if (String.IsNullOrEmpty(policy.Make))
            {
                Console.WriteLine("Auto policy must specify Make");
                return 0m;
            }

            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    return 1000m;
                }
                else
                {
                    return 900m;
                }
            }
            return 0m;
        }
    }
}


