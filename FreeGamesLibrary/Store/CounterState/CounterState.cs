using Fluxor;

namespace FreeGamesLibrary.Store.CounterState
{

    [FeatureState]
    public record CounterState
    {
        public int Counter { get; init; } = 0;


        private CounterState() { } // Required for creating initial state
    }
}
