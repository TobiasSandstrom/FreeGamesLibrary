using Fluxor;

namespace FreeGamesLibrary.Store.UiUseState.Reducers
{
    public partial class Reducers
    {
        [ReducerMethod]
        public static UiState SetLibraryDisplayViewReducer(UiState state, SetLibraryDisplayViewAction action)
        {            
            return state with { LibraryDisplayView = action.View };
        }
    }
}
