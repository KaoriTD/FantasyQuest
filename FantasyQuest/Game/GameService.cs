using FantasyQuest.Adventures;
using Newtonsoft.Json;

namespace FantasyQuest.Game
{
    public class GameService
    {
        public void startGame()
        {
            var bathPath = $"{AppDomain.CurrentDomain.BaseDirectory}/Adventures";
            var initialAdventure = new Adventure();

            if (File.Exists($"{bathPath}\\initial.json"))
            {
                var directory = new DirectoryInfo(bathPath);
                var initialJsonfile = directory.GetFiles("initial.json");

                using StreamReader fi = File.OpenText(initialJsonfile[0].FullName);
                initialAdventure = JsonConvert.DeserializeObject<Adventure>(fi.ReadToEnd());

                Console.WriteLine($"Adventure : {initialAdventure.title}");
                Console.WriteLine($"Description : {initialAdventure.description}");
            }

            Console.WriteLine("You stated the game.");
        }

    }
}
