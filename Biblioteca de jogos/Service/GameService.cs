using Biblioteca_de_jogos.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Biblioteca_de_jogos.Service
{
    internal class GameService
    {
        // propriedade da chave de acesso da API
        private static readonly string key = "d0e502d9dafc45f7b3a5752029a91540";

        // Abaixo estou definindo o objeto de HttpClient que será utilizado, junto à sua rota base. 
        // Desta forma, a requisição de dados será bem mais ágil, o que otimizará o desempenho da aplicação.
        private static readonly HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri($"https://api.rawg.io/api/games?key={key}&page=1&page_size=40")
        };

        // método para retornar os results (que servirão de data source para a combo box de BuscarJogos) 
        public static List<GameDetails> ObterGames()
        {
            // o response está obtendo os recursos da API (por meio de um Get do HttpClient)
            var response = client.GetAsync(client.BaseAddress).Result;
        
            // verificando o status da resposta da API (se ocorreu tudo bem ao fazer o request)
            if (response.StatusCode == HttpStatusCode.OK)
            {
                // responseContent está obtendo todo o conteúdo do response
                var responseContent = response.Content.ReadAsStringAsync().Result;

                // deserializando o conteúdo obtido
                GameResult gameResult = JsonSerializer.Deserialize<GameResult>(responseContent);

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
            // a lógica segue a mesma da do método acima. A diferença é que estou utlizando
            // uma rota diferente, pois ela traz os dados de um jogo específico, baseando-se no seu id
            var response = client.GetAsync($"https://api.rawg.io/api/games/{id}?key={key}&page=1&page_size=40").Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            GameDetails gameDetails = JsonSerializer.Deserialize<GameDetails>(responseContent);
            return gameDetails;
        }
    }
}
