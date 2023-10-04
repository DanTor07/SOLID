using System;

namespace ArdalisRating
{
    public class RatingEngine
    {
        public decimal Rating { get; private set; }

        public void Rate()
        {
            Console.WriteLine("Starting rate.");
            Console.WriteLine("Loading policy.");

            var policyLoader = new PolicyLoader();
            var policyJson = policyLoader.LoadPolicyFromJsonFile("policy.json");

            var policyDeserializer = new PolicyDeserializer();
            var policy = policyDeserializer.DeserializePolicy(policyJson);

            switch (policy.Type)
            {
                case PolicyType.Auto:
                    Rating = RateAutoPolicy.CalculateRating(policy);
                    break;

                case PolicyType.Land:
                    Rating = RateLandPolicy.CalculateRating(policy);
                    break;

                case PolicyType.Life:
                    Rating = RateLifePolicy.CalculateRating(policy);
                    break;

                case PolicyType.Flood:
                    Rating = RateFloodPolicy.CalculateRating(policy);
                    break;

                default:
                    Console.WriteLine("Unknown policy type");
                    break;
            }

            Console.WriteLine("Rating completed.");
        }
    }
}