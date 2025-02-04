using FreeGamesLibrary.Data.Models;

namespace FreeGamesLibrary.Store.UiUseState
{
    public class RandomizeGameAction
    {
        public List<GameSimpleDisplayModel> Games { get; set; }
        public List<GameDetailedDisplayModel> DetailedGames { get; set; }

        public RandomizeGameAction(List<GameSimpleDisplayModel> games, List<GameDetailedDisplayModel> detailedGames)
        {
            Games = games;
            DetailedGames = detailedGames;
        }

    }
}
