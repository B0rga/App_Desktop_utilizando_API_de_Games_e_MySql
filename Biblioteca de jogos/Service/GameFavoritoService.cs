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
        private static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://jsonplaceholder.typicode.com/posts")
        };        

        public static GameFavorito PostarFavorito(string nome, string lancamento, string nota, string genero, string publi, string dev)
        {
            var post = new GameFavorito{ 
                name = nome,
                released = lancamento,
                genre = genero,
                publisher = publi,
                developer = dev,
                rating = nota,
            };

            var json = JsonSerializer.Serialize(post);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(client.BaseAddress, content).Result;

            if (response.IsSuccessStatusCode)
            {
                // recebendo os dados do Post
                var responseContent = response.Content.ReadAsStringAsync().Result;

                // deserializando os dados do Post
                GameFavorito gameFavorito = JsonSerializer.Deserialize<GameFavorito>(responseContent);
                Debug.WriteLine($"\nNome: {gameFavorito.name}\nLançamento: {gameFavorito.released}\nGênero: {gameFavorito.genre}\nPublicadora: {gameFavorito.publisher}\nDesenvolvedora: {gameFavorito.developer}\nNota: {gameFavorito.rating}\n");

                // Inserindo os dados nas tabelas
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
