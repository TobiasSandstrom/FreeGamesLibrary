using Fluxor;
using System.Collections.Immutable;

namespace FreeGamesLibrary.Store.UiUseState.Reducers
{
    public partial class Reducers
    {
        [ReducerMethod]
        public static UiState SetGameGenresReducer(UiState state, SetGameGenresAction action)
        {            
            return state with { GameGenres = action.Games.Select(game => game.Genre).Distinct().ToArray() };
        }
    }
}
