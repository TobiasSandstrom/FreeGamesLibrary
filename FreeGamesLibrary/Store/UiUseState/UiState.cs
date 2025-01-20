using Fluxor;
using FreeGamesLibrary.Data.Models;

namespace FreeGamesLibrary.Store.UiUseState
{

    [FeatureState]
    public record UiState
    {
        // Save all games in this list
        public List<GameSimpleDisplayModel> GamesSimple { get; init; } = new List<GameSimpleDisplayModel>();



        public List<GameSimpleDisplayModel> FeaturedGamesSimple { get; init; } = new List<GameSimpleDisplayModel>();


        private UiState() { } // Required for creating initial state
    }
}
