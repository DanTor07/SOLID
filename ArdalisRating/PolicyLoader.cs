using System.IO;

namespace ArdalisRating
{
    public class PolicyLoader
    {
        public string LoadPolicyFromJsonFile(string fileName)
        {
            return File.ReadAllText(fileName);
        }
    }
}
