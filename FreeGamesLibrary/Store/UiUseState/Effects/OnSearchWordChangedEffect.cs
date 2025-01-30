﻿using Fluxor;

namespace FreeGamesLibrary.Store.UiUseState.Effects
{
    public partial class Effects
    {
        [EffectMethod]
        public async Task OnSearchWordChangedEffect(OnSearchWordChangedAction action, IDispatcher dispatcher)
        { 

{
            dispatcher.Dispatch(new SetSearchWordAction(action.SearchWord));
            dispatcher.Dispatch(new SearchUpdateFilteredGamesAction(action.SearchWord));

            }

        }
    }
}
