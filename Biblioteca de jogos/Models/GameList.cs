using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_jogos.Models
{
    internal class GameList
    {
        public List<GameDisponivel> listaGames { get; set; }

        public GameList() {
            listaGames = new List<GameDisponivel>();
        }
    }
}
