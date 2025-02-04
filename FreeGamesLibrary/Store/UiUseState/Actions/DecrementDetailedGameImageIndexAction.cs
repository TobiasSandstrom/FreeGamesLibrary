using FreeGamesLibrary.Data.Classes;

namespace FreeGamesLibrary.Store.UiUseState
{
    public class DecrementDetailedGameImageIndexAction
    {
        public List<GameImage> GameImages;
        public int CurrentIndex;

        public DecrementDetailedGameImageIndexAction(List<GameImage> gameImages, int currentIndex)
        {
            GameImages = gameImages;
            CurrentIndex = currentIndex;
        }

    }
}
