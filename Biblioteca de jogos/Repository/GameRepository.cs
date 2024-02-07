using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Biblioteca_de_jogos.Models;

namespace Biblioteca_de_jogos.Repository
{
    internal class GameRepository
    {
        // propriedade que define os parâmetros da conexão com o banco
        private static readonly string myConnection = "server=localhost;uid=root;pwd=admin";

        // responsável pela conexão com o banco
        public static MySqlConnection Conexao;

        // responsável pelas intruções a serem executadas
        public static MySqlCommand Comando;

        // responsável por inserir dados a uma tabela
        public static MySqlDataAdapter Adaptador;

        // responsável por ligar o banco em controles com propriedade DataSource
        public static DataTable DadosTabela;

        // método que estabele a conexão com o MySql e criação do banco de dados
        public static void Conectar()
        {
            // estabelece a conexão com Mysql
            Conexao = new MySqlConnection(myConnection);

            // abre a conexão
            Conexao.Open();

            // informa a instrução no Mysql para a criação do novo banco de dados
            Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS bd_GameLibrary; use bd_GameLibrary", Conexao);

            // executa a instrução acima
            Comando.ExecuteNonQuery();

            // informa a instrução no Mysql para a criação de nova tabela
            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS meusJogosFavoritos " +
                                       "(id integer auto_increment primary key, " +
                                       "nome varchar(100), " +
                                       "lancamento varchar(40), " +
                                       "genero varchar(100), " +
                                       "publicadora varchar(100), " +
                                       "desenvolvedora varchar(100), " +
                                       "nota varchar(10)) ", Conexao);

            // executa a instrução acima
            Comando.ExecuteNonQuery();

            // fecha a conexão com o bando de dados
            Conexao.Close();
        }

        // método que irá inserir os dados do jogo favoritado na tabela
        public static void InserirDados(string nome, string lancamento, string genero, string publi, string dev, string nota)
        {
            Conexao = new MySqlConnection(myConnection);
            Conexao.Open();

            Comando = new MySqlCommand("use bd_GameLibrary", Conexao);
            Comando.ExecuteNonQuery();

            // inserção de dados baseado nos parâmetros
            Comando = new MySqlCommand("INSERT INTO meusJogosFavoritos (nome, lancamento, genero, publicadora, desenvolvedora, nota) " +
                                       $"VALUES ('{nome}', '{lancamento}', '{genero}', '{publi}', '{dev}', '{nota}')", Conexao);
            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        // método que verifica se o jogo já está favoritado, retornando true (se estiver), ou false (se não estiver)
        public static bool VerificarJogoJaFavoritado(string nome)
        {
            // variável que diz se o nome está ou não na lista
            bool jogoJaEstaNaLista = false;

            Conexao = new MySqlConnection(myConnection);
            Conexao.Open();

            Comando = new MySqlCommand("use bd_GameLibrary", Conexao);
            Comando.ExecuteNonQuery();

            // comando para consultar os dados da tabela
            Comando = new MySqlCommand("SELECT * FROM meusJogosFavoritos", Conexao);
            Comando.ExecuteNonQuery();

            // Abaixo eu crio um DataReader, que tem como objetivo ler os dados da tabela para utilizá-los em seguida.
            // Neste caso irei comparar os nomes de jogos existentes na tabela com o nome do jogo a ser adicionado.
            MySqlDataReader leitor = Comando.ExecuteReader();

            // loop para ler cada registro da tabela
            while (leitor.Read())
            {
                // assim como um vetor, a contagem dos campos começa do 0. Portando, nesta tabela, o primeiro
                // campo é o "id" (0), e o segundo campo é o "nome" (1). Desta forma, abaixo estou comparando
                // a string do campo 1 com o parâmetro nome (e assim eu verifico todos os nomes da tabela sucessivamente.
                if (leitor.GetString(1) == nome)
                {
                    jogoJaEstaNaLista = true;
                }
            }

            return jogoJaEstaNaLista;
        }

        // método que irá receber os nomes dos jogos da tabela e retornar para listbox
        public static List<string> ReceberDados()
        {
            Conexao = new MySqlConnection(myConnection);
            Conexao.Open();

            Comando = new MySqlCommand("use bd_GameLibrary", Conexao);
            Comando.ExecuteNonQuery();

            // comando para consultar apenas o campo de nomes da tabela
            Comando = new MySqlCommand("SELECT nome FROM meusJogosFavoritos", Conexao);
            Comando.ExecuteNonQuery();

            // criação de um DataReader
            MySqlDataReader leitor = Comando.ExecuteReader();

            // criação de uma list para armazenar os nomes
            List<string> listaNomes = new List<string>();

            // loop para ler cada registro da tabela
            while (leitor.Read())
            {
                // a lógica se dá a mesma da usada no DataReader do método anterior. A diferença é que estou
                // consultando apenas os nomes. Portando, o único e primeiro campo será o nome do jogo, e por
                // isso estou adicionando o "leitor.GetString(0)" à lista.
                listaNomes.Add(leitor.GetString(0));
            }

            Conexao.Close();
            return listaNomes;
        }

        // método que retornará os detalhes do jogo selecionado da lista de favoritos
        public static GameFavorito BuscarDados(string nome)
        {
            Conexao = new MySqlConnection(myConnection);
            Conexao.Open();

            Comando = new MySqlCommand("use bd_GameLibrary", Conexao);
            Comando.ExecuteNonQuery();

            // consultando os dados do jogo com determinado nome
            Comando = new MySqlCommand($"SELECT * FROM meusJogosFavoritos WHERE nome LIKE '{nome}'", Conexao);
            Comando.ExecuteNonQuery();

            MySqlDataReader leitor = Comando.ExecuteReader();

            // instanciando um novo objeto de gameFavorito para receber os dados da tabela
            GameFavorito gameFavorito = new GameFavorito();

            while (leitor.Read())
            {
                // a data de lancamento está no campo 2, o gênero no 3, a publicadora no 4, e assim por diante
                gameFavorito.released = leitor.GetString(2);
                gameFavorito.genre = leitor.GetString(3);
                gameFavorito.publisher = leitor.GetString(4);
                gameFavorito.developer = leitor.GetString(5);
                gameFavorito.rating = leitor.GetString(6);
            }

            Conexao.Close();
            return gameFavorito;
        }

        // método para deletar o jogo selecionado na listbox do banco de dados
        public static void DeletarDados(string nome) {
            Conexao = new MySqlConnection(myConnection);
            Conexao.Open();

            Comando = new MySqlCommand("use bd_GameLibrary", Conexao);
            Comando.ExecuteNonQuery();

            // deletando o jogo com determinado nome
            Comando = new MySqlCommand($"DELETE FROM meusJogosFavoritos WHERE nome LIKE '{nome}'", Conexao);
            Comando.ExecuteNonQuery();
        }    
    }
}
