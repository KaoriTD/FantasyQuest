using FantasyQuest.Adventures;
using System.Linq.Expressions;
using System.Threading.Channels;

namespace FantasyQuest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            makeTitle();
            makeMainMenu();
        }

        private static void makeTitle()
        {
            Console.WriteLine("█▀▀ ▄▀█ █▄░█ ▀█▀ ▄▀█ █▀ █▄█   █▀█ █░█ █▀▀ █▀ ▀█▀");
            Console.WriteLine("█▀░ █▀█ █░▀█ ░█░ █▀█ ▄█ ░█░   ▀▀█ █▄█ ██▄ ▄█ ░█░");
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
                        startGame();
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
            Console.WriteLine("(C)reate new character");
        }
        private static void startGame()
        {
            var bathPath = $"{AppDomain.CurrentDomain.BaseDirectory}/Adventures";
            var initialAdventure = new Adventure();
            
            Console.WriteLine("You stated the game.");
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
