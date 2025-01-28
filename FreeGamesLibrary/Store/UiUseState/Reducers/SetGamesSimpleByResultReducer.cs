using Fluxor;

namespace FreeGamesLibrary.Store.UiUseState.Reducers
{
    public partial class Reducers
    {
        [ReducerMethod]
        public static UiState SetGamesSimpleByResultReducer(UiState state, SetGamesSimpleByResultAction action)
        {
            return state with { GamesSimple = action.Games, FilteredGamesSimple = action.Games };
        }
    }
}
