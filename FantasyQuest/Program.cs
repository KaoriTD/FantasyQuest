using FantasyQuest.Adventures;
using FantasyQuest.Entities;
using FantasyQuest.Game;

namespace FantasyQuest
{
    internal class Program
    {
        private static AdventureService adventureService = new AdventureService();
        private static CharacterService characterService = new CharacterService();
        private static GameService gameService = new GameService(adventureService, characterService);
        static void Main(string[] args)
        {
            makeTitle();
            makeMainMenu();
        }

        private static void makeTitle()
        {
            Console.WriteLine("█▀▀ ▄▀█ █▄░█ ▀█▀ ▄▀█ █▀ █▄█   █▀█ █░█ █▀▀ █▀ ▀█▀");
            Console.WriteLine("█▀░ █▀█ █░▀█ ░█░ █▀█ ▄█ ░█░   ▀▀█ █▄█ ██▄ ▄█ ░█░\n");
        }

        private static void makeMainMenu()
        {
            makeMenuOptions();
            bool inputValid = false;

            while (!inputValid)
            {
                switch (Console.ReadLine().ToUpper())
                {
                    case "S":
                        gameService.StartGame();
                        inputValid = true;
                        break;
                    case "L":
                        loadGame();
                        inputValid = true;
                        break;
                    case "C":
                        createCharacter();
                        inputValid = true;
                        break;
                    default:
                        Console.WriteLine("You didn't put the right letter.");
                        makeMenuOptions();
                        inputValid = false;
                        break;
                }
            }
        }

        private static void makeMenuOptions()
        {
            Console.WriteLine("(S)tart a new game");
            Console.WriteLine("(L)oad a game");
            Console.WriteLine("(C)reate new character\n");
        }

        private static void loadGame()
        {
            throw new NotImplementedException();
        }

        private static void createCharacter()
        {
            throw new NotImplementedException();
        }

        

        

        
    }
}
