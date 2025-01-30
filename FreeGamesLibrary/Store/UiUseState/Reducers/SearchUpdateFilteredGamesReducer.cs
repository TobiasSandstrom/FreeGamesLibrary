using Fluxor;
using System.Collections.Immutable;

namespace FreeGamesLibrary.Store.UiUseState.Reducers
{
    public partial class Reducers
    {
        [ReducerMethod]
        public static UiState SearchUpdateFilteredGamesReducer(UiState state, SearchUpdateFilteredGamesAction action)
        {
            if(!string.IsNullOrEmpty(state.SelectedGenre))
            {
                var res = state.GamesSimple.Where(g => (g.Title.Contains(action.SearchWord) || g.Publisher.Contains(action.SearchWord) || g.Developer.Contains(action.SearchWord)) && g.Genre == state.SelectedGenre);

                return state with { FilteredGamesSimple = res.ToList() };

            }

            return state with { FilteredGamesSimple = state.GamesSimple.Where(g => g.Title.Contains(action.SearchWord) || g.Publisher.Contains(action.SearchWord) || g.Developer.Contains(action.SearchWord)).ToList() };

        }
    }
}
