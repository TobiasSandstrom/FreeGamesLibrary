using FreeGamesLibrary.Data.Models;

namespace FreeGamesLibrary.Store.UiUseState
{
    public class SetFeaturedGamesAction
    {
        public List<GameSimpleDisplayModel> Games { get; set; }

        public SetFeaturedGamesAction(List<GameSimpleDisplayModel> games)
        {
            Games = games;
        }


    }
}
