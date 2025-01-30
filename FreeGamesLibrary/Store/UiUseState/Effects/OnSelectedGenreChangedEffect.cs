using Fluxor;

namespace FreeGamesLibrary.Store.UiUseState.Effects
{
    public partial class Effects
    {
        [EffectMethod]
        public async Task OnSelectedGenreChangedEffect(OnSelectedGenreChangedAction action, IDispatcher dispatcher)
        {

            dispatcher.Dispatch(new SetSelectedGenreAction(action.Genre));
            dispatcher.Dispatch(new SearchUpdateFilterGenreAction(action.Genre));

        }
    }
}
