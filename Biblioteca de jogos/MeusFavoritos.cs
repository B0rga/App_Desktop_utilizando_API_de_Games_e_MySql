using Biblioteca_de_jogos.Models;
using Biblioteca_de_jogos.Repository;
using Biblioteca_de_jogos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Biblioteca_de_jogos
{
    public partial class MeusFavoritos : Form
    {
        Thread t1; // criando uma Thread para navegação entre forms

        public MeusFavoritos()
        {
            InitializeComponent();
            CenterToScreen(); // Inicia o form centralizado
        }

        private void MeusFavoritos_Load(object sender, EventArgs e)
        {
            // variável do tipo lista recebendo os nomes do jogos favoritos do banco de dados
            List<string> listaNomes = GameRepository.ReceberDados();

            // Não é possível editar uma listbox com uma datasource definida
            // (listaFavoritos.DataSource = GameRepository.ReceberDados();)
            // Ou seja, desta forma, não seria possível remover seu elementos em tempo real.
            // Como uma forma de contornar esta situação, eu recebo os dados através de uma List<string>
            // e adiciono eles para a listbox por meio de um foreach
            foreach (string nome in listaNomes)
            {
                listaFavoritos.Items.Add(nome);
            }

            // listbox iniciando sem que haja um item selecionado
            listaFavoritos.ClearSelected();
        }

        // método para a iniciar outro form
        public void abrirBuscarJogos(object obj)
        {
            Application.Run(new BuscarJogos()); // inicia o form BuscarJogos
        }

        // método para a iniciar outro form
        public void abrirTelaInicial(object obg)
        {
            Application.Run(new TelaInicial()); // inicia o form TelaInicial
        }

        // botão do menu que leva até a tela de buscar jogos
        private void btnBuscarJogos_Click(object sender, EventArgs e)
        {
            this.Close(); // fechando tela atual
            t1 = new Thread(abrirBuscarJogos); // instanciando o objeto da Thread e referencando o método que será utilizado
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start(); // executando a thread t1 (executando o form BuscarJogos)
        }

        // botão do menu que leva até a tela inicial
        private void btnTelaInicial_Click(object sender, EventArgs e)
        {
            this.Close(); // fechando tela atual
            t1 = new Thread(abrirTelaInicial); // instanciando o objeto da Thread e referencando o método que será utilizado
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start(); // executando a thread t1 (executando o form TelaInicial)
        }

        // botão que irá remover o jogo selecionado da lista de favoritos (tanto da listbox quando do banco de dados)
        private void btnRemover_Click(object sender, EventArgs e)
        {
            string nome = listaFavoritos.Text; // variável recebendo o nome do jogo selecionado
            GameRepository.DeletarDados(nome); // deletando jogo do banco
            listaFavoritos.Items.Remove(listaFavoritos.SelectedItem); // removendo o jogo da listbox em tempo real

            SoundPlayer removed = new SoundPlayer(@"C:\C#\ProjetosForms\Biblioteca de jogos\Sons\alert.wav");
            removed.Play();
            MessageBox.Show($"{nome} foi removido da sua lista de favoritos.");

            lblLancamento.Visible = false;
            lblGenero.Visible = false;
            lblPubli.Visible = false;
            lblDev.Visible = false;
            lblNota.Visible = false;
            btnRemover.Visible = false;
        }

        // seleção da list box irá chamar o método para exibir detalhes do jogo selecionado
        private void listaFavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = listaFavoritos.Text;

            // o método recebe como parâmetro os dados do return de BuscarDados, que seria um novo objeto de GameFavorito
            MostrarDados(GameRepository.BuscarDados(nome));
        }

        public void MostrarDados(GameFavorito gameFavorito) // novo objeto de GameFavorito sendo instanciado como parâmetro
        {   
            lblLancamento.Visible = true;
            lblGenero.Visible = true;
            lblPubli.Visible = true;
            lblDev.Visible = true;
            lblNota.Visible = true;
            btnRemover.Visible = true;

            // elementos recebendo valores do novo objeto
            resLancamento.Text = gameFavorito.released;
            resNota.Text = gameFavorito.rating;
            resGenero.Text = gameFavorito.genre;
            resPubli.Text = gameFavorito.publisher;
            resDev.Text = gameFavorito.developer;
            resNota.Text = gameFavorito.rating;
        }
    }
}
