using FantasyQuest.Entities.Interfaces;
using FantasyQuest.Entities.Models;
using Newtonsoft.Json;

namespace FantasyQuest.Entities
{
    public class CharacterService : ICharacterService
    {
        public Character LoadCharacter(string name)
        {
            var bathPath = $"{AppDomain.CurrentDomain.BaseDirectory}/Characters";
            var character = new Character();

            if (File.Exists($"{bathPath}\\{name}.json"))
            {
                var directory = new DirectoryInfo(bathPath);
                var characterJsonfile = directory.GetFiles($"{name}.json");

                using StreamReader fi = File.OpenText(characterJsonfile[0].FullName);
                character = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());
            }
            else
            {
                throw new Exception("Character not found.");
            }

            return character;
        }

        public List<Character> GetCharactersInRange(int minLevel = 0, int maxLevel = 20)
        {
            var bathPath = $"{AppDomain.CurrentDomain.BaseDirectory}Characters";
            var charactersInRange = new List<Character>();

            try
            {
                var directory = new DirectoryInfo(bathPath);
                foreach (var file in directory.GetFiles($"*.json"))
                {
                    using (StreamReader fi = File.OpenText(file.FullName))
                    {
                        var potentialCharacterInRange = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());
                        if (potentialCharacterInRange.IsAlive && (potentialCharacterInRange.Level >= minLevel)
                            && potentialCharacterInRange.Level <= maxLevel)
                        {
                            charactersInRange.Add(potentialCharacterInRange);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                {
                    Console.WriteLine($"No Character available {ex.Message}");
                }
               
            }
        return charactersInRange;
        }
    }
}
