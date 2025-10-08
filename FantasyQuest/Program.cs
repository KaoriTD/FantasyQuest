using FantasyQuest.Game;

namespace FantasyQuest
{
    internal class Program
    {
        private static GameService gameService = new GameService();
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
                        gameService.startGame();
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
