using FreeGamesLibrary.Data.Classes;

namespace FreeGamesLibrary.Store.UiUseState
{
    public class IncrementDetailedGameImageIndexAction
    {
        public List<GameImage> GameImages;
        public int CurrentIndex;

        public IncrementDetailedGameImageIndexAction(List<GameImage> gameImages, int currentIndex)
        {
            GameImages = gameImages;
            CurrentIndex = currentIndex;
        }
    }
}
