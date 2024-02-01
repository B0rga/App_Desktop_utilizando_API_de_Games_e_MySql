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
        // propriedade da chave de acesso da API
        private static string key = "d0e502d9dafc45f7b3a5752029a91540";

        // método para retornar os results (que servirão de data source para a combo box dos nomes dos jogos) 
        public static List<GameDetails> ObterGames()
        {
            
            var client = new RestClient($"https://api.rawg.io/api/games?key={key}&page=1&page_size=40");
            RestRequest request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                GameResult gameResult = JsonSerializer.Deserialize<GameResult>(response.Content);
                return gameResult.results;
            }
            else
            {
                return null;
            }
        }

        // método para retornar os dados do jogo escolhido pelo usuário (com base em seu id) 
        public static GameDetails ObterDetalhes(string id)
        {
            var client = new RestClient($"https://api.rawg.io/api/games/{id}?key={key}&page=1&page_size=40");
            RestRequest request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            GameDetails gameDetails = JsonSerializer.Deserialize<GameDetails>(response.Content);
            return gameDetails;
        }
    }
}
