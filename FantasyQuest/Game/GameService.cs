using FantasyQuest.Adventures.Interfaces;
using FantasyQuest.Entities.Interfaces;

namespace FantasyQuest.Game
{
    public class GameService
    {
        private IAdventureService adventureService;
        private ICharacterService characterService;
        public GameService(IAdventureService AdventureService, ICharacterService CharacterService)
        {
            adventureService = AdventureService;
            characterService = CharacterService;
        }

        public void StartGame()
        {
            var initialAdventure = adventureService.GetInitialAdventure();
            var initialCharacter = characterService.LoadInitialCharacter();

            Console.WriteLine($"Adventure : {initialAdventure.title}");
            Console.WriteLine($"Description : {initialAdventure.description}");
            Console.WriteLine($"Character Name : {initialCharacter.Name}");
            Console.WriteLine($"Level : {initialCharacter.Level}");
        }

    }
}
