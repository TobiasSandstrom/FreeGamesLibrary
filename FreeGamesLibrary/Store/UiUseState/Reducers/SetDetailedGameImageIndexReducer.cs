using Fluxor;

namespace FreeGamesLibrary.Store.UiUseState.Reducers
{
    public partial class Reducers
    {
        [ReducerMethod]
        public static UiState SetDetailedGameImageIndexReducer(UiState state, SetDetailedGameImageIndexAction action)
        {            
            return state with { DetailedGameImageIndex = action.Index };
        }
    }
}
