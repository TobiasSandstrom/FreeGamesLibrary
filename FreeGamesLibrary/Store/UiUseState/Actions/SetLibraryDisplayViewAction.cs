using FreeGamesLibrary.Data.Misc;

namespace FreeGamesLibrary.Store.UiUseState
{
    public class SetLibraryDisplayViewAction
    {
        public LibraryDisplayView View {  get; set; }

        public SetLibraryDisplayViewAction(LibraryDisplayView view)
        {
            View = view;
        }

    }
}
