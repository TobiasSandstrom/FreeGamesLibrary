﻿using Fluxor;
using FreeGamesLibrary.Data.Classes;
using FreeGamesLibrary.Data.Misc;
using FreeGamesLibrary.Data.Models;

namespace FreeGamesLibrary.Store.UiUseState
{

    [FeatureState]
    public record UiState
    {
        // Games Simple
        public List<GameSimpleDisplayModel> GamesSimple { get; init; } = new(); // Store all simple games 
        public List<GameSimpleDisplayModel> FeaturedGamesSimple { get; init; } = new(); // Featured games to display
        public List<GameSimpleDisplayModel> FilteredGamesSimple { get; init; } = new(); // Filtered games to display in library
        
        // Games Detailed
        public List<GameDetailedDisplayModel> DetailedGamesCache { get; init; } = new(); // Cache for detailed games
        public GameDetailedDisplayModel DetailedGameToDisplay { get; init; } = new(); // Used in game detailed page

        public string[] GameGenres { get; set; } = [];
        public string SelectedGenre { get; set; } = string.Empty;
        public string SearchWord { get; set; } = string.Empty;
        public GamesSortFilter SortGamesBy { get; set; } = GamesSortFilter.TitleAscending;

        public int DetailedGameImageIndex { get; set; } = 0;
        public GameImage DetailedGameDisplayImage { get; set; } = new();

        public LibraryDisplayView LibraryDisplayView { get; set; } = LibraryDisplayView.GridView;

        private UiState() { } // Required for creating initial state
    }
}
