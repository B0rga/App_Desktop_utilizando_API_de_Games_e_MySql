using Biblioteca_de_jogos.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Biblioteca_de_jogos.Service
{
    internal class GameService
    {
        public static List<GameDetails> ObterGames() // método para retornar os results (que servirão de data source para a combo box dos nomes dos jogos) 
        {
            
            var client = new RestClient("https://api.rawg.io/api/games?key=d0e502d9dafc45f7b3a5752029a91540");
            RestRequest request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            GameResult gameResult = JsonSerializer.Deserialize<GameResult>(response.Content);

            return gameResult.results;
            
        }

        public static GameList ObterDetalhes() // método que retorna a lista de jogos como todos os seus detalhes
        {

            var client = new RestClient("https://api.rawg.io/api/games?key=d0e502d9dafc45f7b3a5752029a91540");
            RestRequest request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            GameResult gameResult = JsonSerializer.Deserialize<GameResult>(response.Content);

            GameList gameList = new GameList();
            for (int i = 0; i < gameResult.results.Count; i++)
            {
                gameList.listaGames.Add(new GameDisponivel
                {
                    nome = gameResult.results[i].name,
                    lancamento = gameResult.results[i].released,
                    imagem = gameResult.results[i].background_image
                });
            }

            return gameList;

        }
    }
}
