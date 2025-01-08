using Fluxor;


namespace FreeGamesLibrary.Store.CounterState.Reducers
{
    public partial class Reducers
    {
        [ReducerMethod]
        public static CounterState IncrementCounterReducer(CounterState state, IncrementCounterAction action)
        {
            return state with { Counter = action.Count + 1 };
        }
    }
}
