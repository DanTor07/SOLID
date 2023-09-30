using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace ArdalisRating
{
    public class PolicyDeserializer
    {
        public Policy DeserializePolicy(string policyJson)
        {
            return JsonConvert.DeserializeObject<Policy>(policyJson, new StringEnumConverter());
        }
    }
}
