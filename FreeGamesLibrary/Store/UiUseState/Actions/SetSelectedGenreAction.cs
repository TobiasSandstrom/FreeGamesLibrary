using FreeGamesLibrary.Data.Models;

namespace FreeGamesLibrary.Store.UiUseState
{
    public class SetSelectedGenreAction
    {
        public string Genre {  get; set; }

        public SetSelectedGenreAction(string genre)
        {
            Genre = genre;
        }

    }
}
