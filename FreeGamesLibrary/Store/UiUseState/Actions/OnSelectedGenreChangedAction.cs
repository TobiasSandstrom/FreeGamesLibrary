using FreeGamesLibrary.Data.Models;

namespace FreeGamesLibrary.Store.UiUseState
{
    public class OnSelectedGenreChangedAction
    {
        public string? Genre {  get; set; }

        public OnSelectedGenreChangedAction(string? genre)
        {
            Genre = genre;
        }

    }
}
