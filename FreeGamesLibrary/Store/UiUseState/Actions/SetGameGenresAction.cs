using FreeGamesLibrary.Data.Models;

namespace FreeGamesLibrary.Store.UiUseState
{
    public class SetGameGenresAction
    {
        public List<GameSimpleDisplayModel> Games {  get; set; }

        public SetGameGenresAction(List<GameSimpleDisplayModel> games)
        {
            Games = games;
        }

    }
}
