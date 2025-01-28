using FreeGamesLibrary.Data.Classes;
using FreeGamesLibrary.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace FreeGamesLibrary.Data.Services
{
    public class GameService : ControllerBase
    {


        public IConfiguration Configuration { get; set; }
        private readonly HttpClient _client;

        public GameService(IConfiguration configuration)
        {
            Configuration = configuration;

            _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.BaseAddress = new Uri(configuration.GetValue<string>("Api:BaseUrl") ?? "");

        }

        #region public functions

        [HttpGet("games-simple")]
        public async Task<List<GameSimpleDisplayModel>> GetGamesSimpleAsync()
        {
            try
            {
                var response = await _client.GetAsync("games");
                if (!response.IsSuccessStatusCode)
                    return [];
                
                var responseBody = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<GameSimple>>(responseBody);
                
                return ConvertGameSimpleToDisplayModel(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Error Fetching GamesSimple from API");
            }
        }        
        
        [HttpGet("game-detailed")]
        public async Task<GameDetailedDisplayModel> GetGameDetailedAsync(int id)
        {
            try
            {
                var response = await _client.GetAsync($"game?id={id}");
                if (!response.IsSuccessStatusCode)
                    return new GameDetailedDisplayModel();
                
                var responseBody = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<GameDetailed>(responseBody);
                
                return ConvertGameDetailedToDisplayModel(result ?? new GameDetailed());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Error Fetching GamesDetailed from API");
            }
        }


        #endregion


        #region private functions

        private List<GameSimpleDisplayModel> ConvertGameSimpleToDisplayModel(List<GameSimple> gamesSimple)
        {
            var res = new List<GameSimpleDisplayModel>();

            foreach (var game in gamesSimple)
            {
                res.Add(new GameSimpleDisplayModel{

                    Developer = game.Developer,
                    FreeToGame_Profile_Url = game.FreeToGame_Profile_Url,
                    Game_Url = game.Game_Url,
                    Genre = game.Genre,
                    Id = game.Id,
                    Platform = GetPlatforms(game.Platform),
                    Publisher = game.Publisher,
                    Release_Date = game.Release_Date,
                    Short_Description = game.Short_Description,
                    Thumbnail = game.Thumbnail,
                    Title = game.Title,
                });
            }
            return res;
        }

        private GameDetailedDisplayModel ConvertGameDetailedToDisplayModel(GameDetailed game)
        {
            return new GameDetailedDisplayModel(){
                Developer = game.Developer,
                FreeToGame_Profile_Url = game.FreeToGame_Profile_Url,
                Game_Url = game.Game_Url,
                Genre = game.Genre,
                Id = game.Id,
                Platform = GetPlatforms(game.Platform),
                Publisher = game.Publisher,
                Release_Date = game.Release_Date,
                Short_Description = game.Short_Description,
                Thumbnail = game.Thumbnail,
                Title = game.Title,
                Description = game.Description,
                Screenshots = game.Screenshots,
                Status = game.Status,
                Minumum_System_Requirements = game.Minumum_System_Requirements,
            };
        }


        private string[] GetPlatforms(string platforms)
        {
            return platforms.Split(",");
        }

        #endregion
    }

}
