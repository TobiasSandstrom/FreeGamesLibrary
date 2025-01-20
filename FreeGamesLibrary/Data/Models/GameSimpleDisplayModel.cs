namespace FreeGamesLibrary.Data.Models
{
    public class GameSimpleDisplayModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Thumbnail { get; set; } = string.Empty;
        public string Short_Description { get; set; } = string.Empty;
        public string Game_Url { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string[] Platform { get; set; } = [];
        public string Publisher { get; set; } = string.Empty;
        public string Developer { get; set; } = string.Empty;
        public string Release_Date { get; set; } = string.Empty;
        public string FreeToGame_Profile_Url { get; set; } = string.Empty;
    }
}
