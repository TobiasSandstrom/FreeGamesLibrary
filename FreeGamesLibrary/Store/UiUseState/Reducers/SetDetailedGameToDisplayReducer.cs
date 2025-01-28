using Fluxor;
using System.Collections.Immutable;

namespace FreeGamesLibrary.Store.UiUseState.Reducers
{
    public partial class Reducers
    {
        [ReducerMethod]
        public static UiState SetDetailedGameToDisplayReducer(UiState state, SetDetailedGameToDisplayAction action)
        {
            if(!state.DetailedGamesCache.Any(c => c.Id == action.Game.Id))
            {
                return state with { DetailedGameToDisplay = action.Game, DetailedGamesCache = state.DetailedGamesCache.Append(action.Game).ToList() };
            }

            return state with { DetailedGameToDisplay = action.Game };

        }
    }
}
