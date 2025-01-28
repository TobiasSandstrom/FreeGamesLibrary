using Fluxor;

namespace FreeGamesLibrary.Store.UiUseState.Effects
{
    public partial class Effects
    {
        [EffectMethod]
        public async Task GetDetailedGameByIDEffect(GetDetailedGameByIDAction action, IDispatcher dispatcher)
        {
            var game = await GameService.GetGameDetailedAsync(action.ID);
            if (game.Id == action.ID)
            {
                dispatcher.Dispatch(new SetDetailedGameToDisplayAction(game));
            }

        }
    }
}
