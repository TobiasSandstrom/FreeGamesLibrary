using FreeGamesLibrary.Data.Models;

namespace FreeGamesLibrary.Store.UiUseState
{
    public class SetGamesSimpleByResultAction
    {
        public List<GameSimpleDisplayModel> Games {  get; set; }

        public SetGamesSimpleByResultAction(List<GameSimpleDisplayModel> games)
        {
            Games = games;
        }
    }
}
