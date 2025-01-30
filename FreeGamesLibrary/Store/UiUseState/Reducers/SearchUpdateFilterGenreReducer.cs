using Fluxor;
using System.Collections.Immutable;

namespace FreeGamesLibrary.Store.UiUseState.Reducers
{
    public partial class Reducers
    {
        [ReducerMethod]
        public static UiState SearchUpdateFilterGenreReducer(UiState state, SearchUpdateFilterGenreAction action)
        {
            if (!string.IsNullOrEmpty(action.Genre))
            {
                var res = state.GamesSimple.Where(g => g.Genre == action.Genre).ToList();
                if (!string.IsNullOrEmpty(state.SearchWord))
                {
                    res = res.Where(g => g.Title.Contains(state.SearchWord) || g.Publisher.Contains(state.SearchWord) || g.Developer.Contains(state.SearchWord)).ToList();
                }
                return state with { FilteredGamesSimple = res };
            }
            else
            {
                return state with { FilteredGamesSimple = state.GamesSimple.Where(g => g.Title.Contains(state.SearchWord) || g.Publisher.Contains(state.SearchWord) || g.Developer.Contains(state.SearchWord)).ToList() };
            }

        }
    }
}
