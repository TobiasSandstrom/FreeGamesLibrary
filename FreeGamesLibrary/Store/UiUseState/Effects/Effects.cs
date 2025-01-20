using FreeGamesLibrary.Data.Services;

namespace FreeGamesLibrary.Store.UiUseState.Effects
{
    public partial class Effects
    {
        private GameService GameService;


        public Effects(GameService gameService)
        {
            GameService = gameService;
        }
    }
}
