namespace FreeGamesLibrary.Store.CounterState
{
    public class IncrementCounterAction
    {
        public int Count {  get; set; }

        public IncrementCounterAction(int count)
        {
            Count = count;
        }



    }
}
