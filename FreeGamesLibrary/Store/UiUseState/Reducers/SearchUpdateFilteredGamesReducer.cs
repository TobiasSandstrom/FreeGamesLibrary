using Fluxor;
using System.Collections.Immutable;

namespace FreeGamesLibrary.Store.UiUseState.Reducers
{
    public partial class Reducers
    {
        [ReducerMethod]
        public static UiState SearchUpdateFilteredGamesReducer(UiState state, SearchUpdateFilteredGamesAction action)
        {

            return state with { FilteredGamesSimple = state.GamesSimple.Where(g => g.Title.Contains(action.SearchWord) || g.Genre.Contains(action.SearchWord) || g.Publisher.Contains(action.SearchWord) || g.Developer.Contains(action.SearchWord)).ToList() };

        }
    }
}
