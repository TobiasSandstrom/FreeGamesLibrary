namespace FreeGamesLibrary.Store.UiUseState
{
    public class OnSearchWordChangedAction
    {
        public string SearchWord {  get; set; }

        public OnSearchWordChangedAction(string searchWord)
        {
            SearchWord = searchWord;
        }

    }
}
