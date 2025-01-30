using Fluxor;
using System.Collections.Immutable;

namespace FreeGamesLibrary.Store.UiUseState.Reducers
{
    public partial class Reducers
    {
        [ReducerMethod]
        public static UiState SetGameFilterReducer(UiState state, SetGameFilterAction action)
        {            
            return state with { SortGamesBy = action.Filter };
        }
    }
}
