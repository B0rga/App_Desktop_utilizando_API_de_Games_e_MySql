using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_jogos.Models
{
    public class GameResult
    {
        public List<GameDetails> results { get; set; }
    }
    public class GameDetails
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
    public class Gender
    {
        public string name { get; set; }
    }

    public class Publisher
    {
        public string name { get; set; }
    }

    public class Developer
    {
        public string name { get; set; }
    }
}
