using Fluxor;

namespace FreeGamesLibrary.Store.UiUseState.Reducers
{
    public partial class Reducers
    {
        [ReducerMethod]
        public static UiState SetDetailedGameDisplayImageReducer(UiState state, SetDetailedGameDisplayImageAction action)
        {            
            return state with { DetailedGameDisplayImage = action.Image };
        }
    }
}
