using FreeGamesLibrary.Data.Classes;
using FreeGamesLibrary.Data.Models;

namespace FreeGamesLibrary.Store.UiUseState
{
    public class SetDetailedGameDisplayImageAction
    {
        public GameImage Image {  get; set; }

        public SetDetailedGameDisplayImageAction(GameImage image)
        {
            Image = image;
        }

    }
}
