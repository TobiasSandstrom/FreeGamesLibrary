using Fluxor;
using System.Collections.Immutable;

namespace FreeGamesLibrary.Store.UiUseState.Reducers
{
    public partial class Reducers
    {
        [ReducerMethod]
        public static UiState SetSelectedGenreReducer(UiState state, SetSelectedGenreAction action)
        {            
            return state with { SelectedGenre = action.Genre };
        }
    }
}
