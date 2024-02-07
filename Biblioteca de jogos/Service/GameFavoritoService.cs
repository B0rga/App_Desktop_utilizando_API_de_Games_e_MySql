using Biblioteca_de_jogos.Models;
using Biblioteca_de_jogos.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Biblioteca_de_jogos.Service
{
    public class GameFavoritoService
    {
        // Abaixo estou definindo o objeto de HttpClient que será utilizado, junto à sua rota base. 
        // Desta forma, a requisição de dados será bem mais ágil, o que otimizará o desempenho da aplicação.
        private static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://jsonplaceholder.typicode.com/posts")
        };

        // Método abaixo será responsável por fazer POST do jogo favorito e armazená-lo no banco de dados
        public static GameFavorito PostarFavorito(string nome, string lancamento, string nota, string genero, string publi, string dev)
        {
            // criando novo objeto de GameFavorito e passando os valores dos parâmetros
            var post = new GameFavorito{ 
                name = nome,
                released = lancamento,
                genre = genero,
                publisher = publi,
                developer = dev,
                rating = nota,
            };

            // serializando os dados do objetos para ficar no formato JSON
            var json = JsonSerializer.Serialize(post);

            // criando nova linha de conteúdo com os dados serializados
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // o response está obtendo os recursos que estão sendo postados pelo HttpClient
            var response = client.PostAsync(client.BaseAddress, content).Result;

            if (response.IsSuccessStatusCode)
            {
                // recebendo os dados do Post
                var responseContent = response.Content.ReadAsStringAsync().Result;

                // deserializando os dados do Post
                GameFavorito gameFavorito = JsonSerializer.Deserialize<GameFavorito>(responseContent);

                // Cada vez que o usuário favoritar um jogo, serão lançados estes dados no Debug
                Debug.WriteLine($"\nNome: {gameFavorito.name}\nLançamento: {gameFavorito.released}\nGênero: {gameFavorito.genre}\nPublicadora: {gameFavorito.publisher}\nDesenvolvedora: {gameFavorito.developer}\nNota: {gameFavorito.rating}\n");

                // Inserindo estes dados na tabela do banco de dados
                GameRepository.InserirDados(gameFavorito.name, gameFavorito.released, gameFavorito.genre, gameFavorito.publisher, gameFavorito.developer, gameFavorito.rating);

                return gameFavorito;
            }
            else
            {
                Debug.WriteLine("Error: "+ response.StatusCode);
                return null;
            }
        }
    }
}
