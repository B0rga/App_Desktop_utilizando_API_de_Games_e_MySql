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
        private static readonly string myConnection = "server=localhost;uid=root;pwd=admin";

        // responsável pela conexão com o banco
        public static MySqlConnection Conexao;

        // responsável pelas intruções a serem executadas
        public static MySqlCommand Comando;

        // responsável por inserir dados a uma tabela
        public static MySqlDataAdapter Adaptador;

        // responsável por ligar o banco em controles com propriedade DataSource
        public static DataTable DadosTabela;


        public static void Conectar()
        {   
            // estabelece os parâmetros para a conexão com o banco
            Conexao = new MySqlConnection(myConnection);
            
            // abre a conexão com o banco de dados
            Conexao.Open();

            // informa a instrução no Mysql para a criação de novo banco de dados
            Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS bd_GameLibrary; use bd_GameLibrary", Conexao);

            // Executa a Query no Mysql (comando acima)
            Comando.ExecuteNonQuery();

            // informa a instrução no Mysql para a criação de nova tabela
            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS meusJogosFavoritos " +
                                       "(id integer auto_increment primary key, " +
                                       "nome varchar(40), " +
                                       "lancamento varchar(40), " +
                                       "genero varchar(40), " +
                                       "publicadora varchar(40), " +
                                       "desenvolvedora varchar(40), " +
                                       "nota varchar(10)) ", Conexao);
            
            // Executa a Query no Mysql (comando acima)
            Comando.ExecuteNonQuery();

            // Fecha a conexão com o bando de dados
            Conexao.Close();
        }

        public static void InserirDados(string nome, string lancamento, string genero, string publi, string dev, string nota)
        {
            Conexao = new MySqlConnection(myConnection);
            Conexao.Open();

            Comando = new MySqlCommand("use bd_GameLibrary", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("INSERT INTO meusJogosFavoritos (nome, lancamento, genero, publicadora, desenvolvedora, nota) " +
                                       $"VALUES ('{nome}', '{lancamento}', '{genero}', '{publi}', '{dev}', '{nota}')", Conexao);
            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public static bool VerificarJogoJaFavoritado(string nome)
        {
            bool jogoJaEstaNaLista = false;

            Conexao = new MySqlConnection(myConnection);
            Conexao.Open();

            Comando = new MySqlCommand("use bd_GameLibrary", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("SELECT * FROM meusJogosFavoritos", Conexao);
            Comando.ExecuteNonQuery();

            MySqlDataReader leitor = Comando.ExecuteReader();

            while (leitor.Read())
            {
                if(leitor.GetString(1) == nome)
                {
                    jogoJaEstaNaLista = true;
                }
                else
                {
                    jogoJaEstaNaLista = false;
                }
            }

            return jogoJaEstaNaLista;
        }

        public static List<string> ReceberDados()
        {
            Conexao = new MySqlConnection(myConnection);
            Conexao.Open();

            Comando = new MySqlCommand("use bd_GameLibrary", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("SELECT nome FROM meusJogosFavoritos", Conexao);
            Comando.ExecuteNonQuery();

            MySqlDataReader leitor = Comando.ExecuteReader();

            List<string> listaNomes = new List<string>();

            while(leitor.Read())
            {
                listaNomes.Add(leitor.GetString(0));
            }
            
            Conexao.Close();
            return listaNomes;
        }

        public static GameFavorito BuscarDados(string nome)
        {
            Conexao = new MySqlConnection(myConnection);
            Conexao.Open();

            Comando = new MySqlCommand("use bd_GameLibrary", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand($"SELECT * FROM meusJogosFavoritos WHERE nome LIKE '{nome}'", Conexao);
            Comando.ExecuteNonQuery();

            MySqlDataReader leitor = Comando.ExecuteReader();
            GameFavorito gameFavorito = new GameFavorito();

            while (leitor.Read())
            {
                gameFavorito.released = leitor.GetString(2);
                gameFavorito.genre = leitor.GetString(3);
                gameFavorito.publisher = leitor.GetString(4);
                gameFavorito.developer = leitor.GetString(5);
                gameFavorito.rating = leitor.GetString(6);
            }

            Conexao.Close();
            return gameFavorito;
        }

        public static void DeletarDados(string nome) {
            Conexao = new MySqlConnection(myConnection);
            Conexao.Open();

            Comando = new MySqlCommand("use bd_GameLibrary", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand($"DELETE FROM meusJogosFavoritos WHERE nome LIKE '{nome}'", Conexao);
            Comando.ExecuteNonQuery();
        }    
    }
}
