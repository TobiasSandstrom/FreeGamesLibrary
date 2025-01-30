using FreeGamesLibrary.Data.Misc;

namespace FreeGamesLibrary.Store.UiUseState
{
    public class SetGameFilterAction
    {
        public GamesSortFilter Filter {  get; set; }

        public SetGameFilterAction(GamesSortFilter filter)
        {
            Filter = filter;
        }

    }
}
