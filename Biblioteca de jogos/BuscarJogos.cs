using Biblioteca_de_jogos.Models;
using Biblioteca_de_jogos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public void abrirMeusFavoritos(object obj) // método para a iniciar outro form
        {
            Application.Run(new MeusFavoritos()); // inicia o form MeusFavoritos
        }

        public void abrirTelaInicial(object obg) // método para a iniciar outro form
        {
            Application.Run(new TelaInicial()); // inicia o form TelaInicial
        }

        private void btnMeusFavoritos_Click(object sender, EventArgs e)
        {
            this.Close(); // fechando tela atual
            t1 = new Thread(abrirMeusFavoritos); // instanciando o objeto da Thread e referencando o método que será utilizado
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start(); // executando a thread t1 (executando o form MeusFavoritos)
        }

        private void btnTelaInicial_Click(object sender, EventArgs e)
        {
            this.Close(); // fechando tela atual
            t1 = new Thread(abrirTelaInicial); // instanciando o objeto da Thread e referencando o método que será utilizado
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start(); // executando a thread t1 (executando o form TelaInicial)
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void cbJogos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFavoritar_Click(object sender, EventArgs e)
        {

            if (lista.Items.Contains(cbJogos.Text)) // verificando se o item selecionado já não existe na lista
            {
                MessageBox.Show("Jogo já favoritado!");
            }
            else
            {
                
                lista.Items.Add(cbJogos.Text); // adicionando valores da combobox para listbox
            }
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // objeto results recebendo os dados da API 
            GameResult gameResult = new GameResult();
            gameResult.results = GameService.ObterGames();

            // por meio deste for eu consigo trazer os dados correspondentes do jogo selecionado da combobox
            // e alterar os elementos do form de acordo com os detalhes desse jogo
            for(int i=0; i<=cbJogos.SelectedIndex; i++) {
                resLancamento.Text = gameResult.results[i].released;
                resNota.Text = gameResult.results[i].rating.ToString();
                imgGames.ImageLocation = gameResult.results[i].background_image;
                foreach(var gender in gameResult.results[i].genres)
                {
                    resGenero.Text = gender.name;
                }
            }
        }
    }
}
