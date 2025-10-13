using FantasyQuest.Adventures;

namespace FantasyQuest.Game.Interfaces
{
    public interface IGameService
    {
        bool StartGame(Adventure adventure = null);
    }
}