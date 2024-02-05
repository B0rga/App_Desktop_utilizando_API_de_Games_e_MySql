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
            // lista recebendo os nomes do jogos favoritos do banco de dados
            List<string> listaNomes = GameRepository.ReceberDados();

            foreach(string nome in listaNomes)
            {
                listaFavoritos.Items.Add(nome);
            }

            // listbox iniciando sem que haja um item selecionado
            listaFavoritos.SelectedIndex = -1;
        }

        public void abrirBuscarJogos(object obj) // método para a iniciar outro form
        {
            Application.Run(new BuscarJogos()); // inicia o form BuscarJogos
        }

        public void abrirTelaInicial(object obg) // método para a iniciar outro form
        {
            Application.Run(new TelaInicial()); // inicia o form TelaInicial
        }

        private void btnBuscarJogos_Click(object sender, EventArgs e)
        {
            this.Close(); // fechando tela atual
            t1 = new Thread(abrirBuscarJogos); // instanciando o objeto da Thread e referencando o método que será utilizado
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start(); // executando a thread t1 (executando o form BuscarJogos)
        }

        private void btnTelaInicial_Click(object sender, EventArgs e)
        {
            this.Close(); // fechando tela atual
            t1 = new Thread(abrirTelaInicial); // instanciando o objeto da Thread e referencando o método que será utilizado
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start(); // executando a thread t1 (executando o form TelaInicial)
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string nome = listaFavoritos.Text;
            GameRepository.DeletarDados(nome);
            listaFavoritos.Items.Remove(listaFavoritos.SelectedItem);

            MessageBox.Show($"{nome} foi removido da sua lista de favoritos.");
        }

        private void listaFavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = listaFavoritos.Text;
            MostrarDados(GameRepository.BuscarDados(nome));
        }

        public void MostrarDados(GameFavorito gameFavorito) // novo objeto sendo instanciado como parâmetro
        {   
            // os dados apenas serão exibidos na tela se houver um jogo selecionado
            if(listaFavoritos.SelectedIndex == -1)
            {
                lblLancamento.Visible = false;
                lblGenero.Visible = false;
                lblPubli.Visible = false;
                lblDev.Visible = false;
                lblNota.Visible = false;

                resLancamento.Text = null;
                resNota.Text = null;
                resGenero.Text = null;
                resPubli.Text = null;
                resDev.Text = null;
                resNota.Text = null;
            }
            else
            {
                lblLancamento.Visible = true;
                lblGenero.Visible = true;
                lblPubli.Visible = true;
                lblDev.Visible = true;
                lblNota.Visible = true;

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
}
