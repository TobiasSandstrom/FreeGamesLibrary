using FreeGamesLibrary.Data.Models;

namespace FreeGamesLibrary.Store.UiUseState
{
    public class SetDetailedGameToDisplayAction
    {
        public GameDetailedDisplayModel Game {  get; set; }

        public SetDetailedGameToDisplayAction(GameDetailedDisplayModel game)
        {
            Game = game;
        }

    }
}
