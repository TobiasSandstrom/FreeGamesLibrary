using Fluxor;
using FreeGamesLibrary.Data.Models;

namespace FreeGamesLibrary.Store.UiUseState
{

    [FeatureState]
    public record UiState
    {
        // Save all games in this list
        public List<GameSimpleDisplayModel> GamesSimple { get; init; } = new();
        public List<GameSimpleDisplayModel> FeaturedGamesSimple { get; init; } = new();
        public List<GameSimpleDisplayModel> FilteredGamesSimple { get; init; } = new();



        private UiState() { } // Required for creating initial state
    }
}
