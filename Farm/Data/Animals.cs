using System.Collections.Generic;

namespace Farm.Data
{
    public static class Animals
    {
        public static IEnumerable<AnimalInfo> All => new[]
        {
            new AnimalInfo("Cat", "The barn yard cat is a staple of many farms."),
            new AnimalInfo("Chicken", "Providing fresh eggs and constant clucking."),
            new AnimalInfo("Cow", "Cow's are the source of milk and beef."),
            new AnimalInfo("Dog", "Every farmer needs a trusty dog to keep watch."),
            new AnimalInfo("Donkey", "The trusty animal can make hard labor easier."),
            new AnimalInfo("Horse", "Help farmers cover long distances faster. YeeHaw!"),
            new AnimalInfo("Pig", "These messy animals are fun to have around."),
            new AnimalInfo("Rooster", "Helping farmers wake up early everywhere."),
            new AnimalInfo("Sheep", "A great source of wool for those cold winters.")
        };
        
        public sealed record AnimalInfo(string Name, string Description)
        {
            public string ImageUrl => $"/img/{Name.ToLowerInvariant()}.png";
            public string WavUrl => $"/audio/{Name.ToLowerInvariant()}.wav";
        }
    }
}