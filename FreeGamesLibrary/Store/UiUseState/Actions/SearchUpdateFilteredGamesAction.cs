using FreeGamesLibrary.Data.Models;

namespace FreeGamesLibrary.Store.UiUseState
{
    public class SearchUpdateFilteredGamesAction
    {
        public string SearchWord { get; set; }

        public SearchUpdateFilteredGamesAction(string searchWord)
        {
            SearchWord = searchWord;
        }


    }
}
