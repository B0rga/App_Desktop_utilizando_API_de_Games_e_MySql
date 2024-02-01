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
        public int id { get; set; }
        public string name { get; set; }
        public string released { get; set; }
        public string background_image { get; set; }
        public double rating { get; set; }
        public List<Gender> genres { get; set; }
        public List<Publisher> publishers { get; set; }
        public List<Developer> developers { get; set; }

    }
    internal class Gender
    {
        public string name { get; set; }
    }

    internal class Publisher
    {
        public string name { get; set; }
    }

    internal class Developer
    {
        public string name { get; set; }
    }
}
