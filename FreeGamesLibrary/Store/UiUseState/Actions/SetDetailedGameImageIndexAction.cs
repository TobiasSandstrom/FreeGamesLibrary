using FreeGamesLibrary.Data.Models;

namespace FreeGamesLibrary.Store.UiUseState
{
    public class SetDetailedGameImageIndexAction
    {
        public int Index {  get; set; }

        public SetDetailedGameImageIndexAction(int index)
        {
            Index = index;
        }

    }
}
