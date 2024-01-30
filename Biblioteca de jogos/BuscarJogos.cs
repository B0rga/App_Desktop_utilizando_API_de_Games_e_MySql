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
    }
}
