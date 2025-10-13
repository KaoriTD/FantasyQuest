using FantasyQuest.Adventures;
using FantasyQuest.Adventures.Interfaces;
using FantasyQuest.Entities.Interfaces;
using FantasyQuest.Entities.Models;
using FantasyQuest.Game.Interfaces;

namespace FantasyQuest.Game
{
    public class GameService : IGameService
    {
        private IAdventureService adventureService;
        private ICharacterService characterService;
        private Character character;
        public GameService(IAdventureService AdventureService, ICharacterService CharacterService)
        {
            adventureService = AdventureService;
            characterService = CharacterService;
        }

        public bool StartGame(Adventure adventure = null)
        {
            try
            {
                if (adventure == null)
                {
                    adventure = adventureService.GetInitialAdventure();
                }

                Console.Clear();
                Console.WriteLine();

                //Create Title Banner
                for (int i = 0; i <= adventure.Title.Length + 3; i++)
                {
                    Console.Write("*");
                    if (i == adventure.Title.Length + 3)
                    {
                        Console.Write("\n");
                    }
                }
                Console.WriteLine($"| {adventure.Title.ToUpper()} |");
                for (int i = 0; i <= adventure.Title.Length + 3; i++)
                {
                    Console.Write("*");
                    if (i == adventure.Title.Length + 3)
                    {
                        Console.Write("\n");
                    }
                }

                Console.WriteLine($"\n{adventure.Description}");

                var charactersInRange = characterService.GetCharactersInRange(adventure.MinimumLevel, adventure.MaxLevel);

                if (charactersInRange.Count == 0)
                {
                    Console.WriteLine("Sorry. You do not have any character in the range level of the adventure you are trying to play.");
                    return false;
                }
                else
                {
                    Console.WriteLine("You are ...");
                    var characterCount = 0;
                    foreach (var character in charactersInRange)
                    {
                        Console.WriteLine($"#{characterCount} {character.Name} Level - {character.Level} {character.CharacterClass}");
                        characterCount++;
                    }
                }
                character = characterService.LoadCharacter(charactersInRange[Convert.ToInt32(Console.ReadLine())].Name);

                Monster myMonster = new Monster();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            return true;
        }
    }
}
