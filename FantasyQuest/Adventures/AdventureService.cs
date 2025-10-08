using FantasyQuest.Adventures.Interfaces;
using Newtonsoft.Json;

namespace FantasyQuest.Adventures
{
    public class AdventureService : IAdventureService
    {
        public Adventure GetInitialAdventure()
        {
            var bathPath = $"{AppDomain.CurrentDomain.BaseDirectory}/Adventures";
            var initialAdventure = new Adventure();

            if (File.Exists($"{bathPath}\\initial.json"))
            {
                var directory = new DirectoryInfo(bathPath);
                var initialJsonfile = directory.GetFiles("initial.json");

                using StreamReader fi = File.OpenText(initialJsonfile[0].FullName);
                initialAdventure = JsonConvert.DeserializeObject<Adventure>(fi.ReadToEnd());
            }

            return initialAdventure;
        }
    }
}
