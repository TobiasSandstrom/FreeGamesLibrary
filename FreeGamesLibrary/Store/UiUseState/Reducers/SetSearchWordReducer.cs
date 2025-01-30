using Fluxor;
using System.Collections.Immutable;

namespace FreeGamesLibrary.Store.UiUseState.Reducers
{
    public partial class Reducers
    {
        [ReducerMethod]
        public static UiState SetSearchWordReducer(UiState state, SetSearchWordAction action)
        {            
            return state with { SearchWord = action.SearchWord };
        }
    }
}
