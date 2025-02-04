﻿using Fluxor;

namespace FreeGamesLibrary.Store.UiUseState.Effects
{
    public partial class Effects
    {
        [EffectMethod]
        public async Task DecrementDetailedGameImageIndexEffect(DecrementDetailedGameImageIndexAction action, IDispatcher dispatcher)
        {

            var index = (action.CurrentIndex - 1 + action.GameImages.Count) % action.GameImages.Count;

            dispatcher.Dispatch(new SetDetailedGameImageIndexAction(index));
            dispatcher.Dispatch(new SetDetailedGameDisplayImageAction(action.GameImages[index]));

        }
    }
}
