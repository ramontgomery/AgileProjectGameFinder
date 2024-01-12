using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Models.Games
{
    public class GamesModels
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public Genre Genre { get; set; }
        public GameConsole GameConsole { get; set; }
        public Ratings Rating { get; set; }
        public DateTime DateReleased { get; set; }

    }
}