using Fluxor;
using System.Collections.Immutable;

namespace FreeGamesLibrary.Store.UiUseState.Reducers
{
    public partial class Reducers
    {
        [ReducerMethod]
        public static UiState SetFeaturedGamesReducer(UiState state, SetFeaturedGamesAction action)
        {
            Random _random = new Random();
            return state with { FeaturedGamesSimple = action.Games.OrderBy(g => _random.Next()).Take(3).ToList() };

            
        }
    }
}
