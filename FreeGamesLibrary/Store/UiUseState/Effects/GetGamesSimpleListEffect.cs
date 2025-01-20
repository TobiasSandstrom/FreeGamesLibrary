using Fluxor;

namespace FreeGamesLibrary.Store.UiUseState.Effects
{
    public partial class Effects
    {

        [EffectMethod]
        public async Task GetGamesSimpleListEffect(GetGamesSimpleListAction action, IDispatcher dispatcher)
        {

            var games = await GameService.GetGamesSimpleAsync();
            if (games != null) dispatcher.Dispatch(new SetGamesSimpleByResultAction(games));


        }
    }
}
