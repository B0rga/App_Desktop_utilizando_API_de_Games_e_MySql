using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_jogos.Models
{
    internal class GameResult
    {
        public List<GameDetails> results { get; set; }
    }
    internal class GameDetails
    {
        public string name { get; set; }
        public string released { get; set; }
        public string background_image { get; set; }
    }
}
