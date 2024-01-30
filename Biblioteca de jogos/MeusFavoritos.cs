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

        }

        private void listaFavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
