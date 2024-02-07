using Biblioteca_de_jogos.Models;
using Biblioteca_de_jogos.Repository;
using Biblioteca_de_jogos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Biblioteca_de_jogos
{
    public partial class BuscarJogos : Form
    {
        Thread t1; // criando uma Thread para navegação entre forms

        public BuscarJogos()
        {
            InitializeComponent();
            CenterToScreen(); // Inicia o form centralizado
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // combo box obtendo dados da API assim que o form inicia
            cbJogos.DataSource = GameService.ObterGames();
            
            // verificando se a API está funcionando
            if (cbJogos.DataSource == null)
            {
                MessageBox.Show("Serviço indiponível no momento: RAWG API");
            }
            
            // combobox iniciada sempre com um valor padrão
            cbJogos.SelectedItem = null;
            cbJogos.SelectedText = "Selecione um jogo";
        }

        // método para a iniciar outro form
        public void abrirMeusFavoritos(object obj)
        {
            Application.Run(new MeusFavoritos()); // inicia o form MeusFavoritos
        }

        // método para a iniciar outro form
        public void abrirTelaInicial(object obg) 
        {
            Application.Run(new TelaInicial()); // inicia o form TelaInicial
        }

        // botão do menu que leva até a tela de favoritos
        private void btnMeusFavoritos_Click(object sender, EventArgs e) 
        {
            this.Close(); // fechando tela atual
            t1 = new Thread(abrirMeusFavoritos); // instanciando o objeto da Thread e referencando o método que será utilizado
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start(); // executando a thread t1 (executando o form MeusFavoritos)
        }

        // botão do menu que leva até a tela inicial
        private void btnTelaInicial_Click(object sender, EventArgs e) 
        {
            this.Close(); // fechando tela atual
            t1 = new Thread(abrirTelaInicial); // instanciando o objeto da Thread e referencando o método que será utilizado
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start(); // executando a thread t1 (executando o form TelaInicial)
        }

        // botão para buscar dados do jogo selecionado da combobox
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // verificando se há um jogo selecionado
            if(cbJogos.SelectedItem == null){
                MessageBox.Show("Selecione um jogo!");
            }
            else
            {
                // a variável abaixo está recebendo o id associado ao nome do jogo selecionado na combobox
                string id = cbJogos.SelectedValue.ToString();

                // logo após eu utilizo este id para fazer a requisição dos dados deste jogo.
                // O método será executado recebendo como parâmetro o return do método ObterDetalhes
                // (que retorna o objeto gameDetails)
                MostrarDados(GameService.ObterDetalhes(id));
                
                // tornando elementos visíveis
                btnFavoritar.Visible = true;
                lblLancamento.Visible = true;
                lblGenero.Visible = true;
                lblPubli.Visible = true;
                lblDev.Visible = true;
                lblNota.Visible = true;
            }
        }

        // método que irá transformar os elementos do form nos dados do jogo selecionado
        private void MostrarDados(GameDetails gameDetails) // novo objeto sendo instanciado como parâmetro
        {
            resLancamento.Text = gameDetails.released;
            resNota.Text = gameDetails.rating.ToString();
            imgGames.ImageLocation = gameDetails.background_image;

            foreach (var genre in gameDetails.genres)
            {
                resGenero.Text = genre.name;
            }
            foreach (var publi in gameDetails.publishers)
            {
                resPubli.Text = publi.name;
            }
            foreach (var dev in gameDetails.developers)
            {
                resDev.Text = dev.name;
            }
        }

        // botão que que chamará o método de favoritar o jogo selecionado
        private void btnFavoritar_Click(object sender, EventArgs e)
        {
            // verificando se há um jogo selecionado
            if (cbJogos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um jogo!");
            }
            else
            {
                FavoritarJogo();
            }
        }

        // método que irá lançar o jogo selecionado e seus dados para o banco de dados
        private void FavoritarJogo()
        {
            string nome = cbJogos.Text;

            // a variável abaixo está recebendo o return de um método booleano para verificar
            // se o jogo selecionado já está favoritado (se já está ou não no banco de dados)
            bool jogoJaFavoritado = GameRepository.VerificarJogoJaFavoritado(nome);

            if(jogoJaFavoritado == false)
            {
                // se o jogo não estiver favoritado, o método de POST será chamado para enviar
                // os dados do jogo uma API ao mesmo tempo que os envia para o banco de dados
                GameFavoritoService.PostarFavorito(cbJogos.Text, resLancamento.Text, resNota.Text, resGenero.Text, resPubli.Text, resDev.Text);
                MessageBox.Show($"{cbJogos.Text} agora está na sua lista de favoritos!");
                btnFavoritar.Visible = false;
            }
            else if(jogoJaFavoritado == true)
            {
                MessageBox.Show($"Este jogo já está na sua lista!");
            }    
        }
    }
}
