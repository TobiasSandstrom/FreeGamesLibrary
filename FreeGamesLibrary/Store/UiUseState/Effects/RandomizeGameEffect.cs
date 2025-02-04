using Fluxor;
using FreeGamesLibrary.Data.Models;

namespace FreeGamesLibrary.Store.UiUseState.Effects
{
    public partial class Effects
    {
        [EffectMethod]
        public async Task RandomizeGameEffect(RandomizeGameAction action, IDispatcher dispatcher)
        {

            Random _random = new Random();
            var randomGame = action.Games.OrderBy(g => _random.Next()).Take(1);

            if (randomGame.FirstOrDefault() != null)
            {
                if (action.DetailedGames.Any(x => x.Id == randomGame.FirstOrDefault().Id))
                {
                    dispatcher.Dispatch(new SetDetailedGameToDisplayAction(action.DetailedGames.FirstOrDefault(x => x.Id == randomGame.First().Id)));
                }
                else {
                    var fetchedRandomGame = await GameService.GetGameDetailedAsync(randomGame.FirstOrDefault().Id);
                    dispatcher.Dispatch(new SetDetailedGameToDisplayAction(fetchedRandomGame));

                }

            }

            dispatcher.Dispatch(new SetDetailedGameToDisplayAction(new GameDetailedDisplayModel()));

        }
    }
}
