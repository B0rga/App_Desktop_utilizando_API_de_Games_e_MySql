using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Biblioteca_de_jogos.Repository;

namespace Biblioteca_de_jogos
{
    public partial class TelaInicial : Form
    {
        Thread t1; // criando uma Thread para navegação entre forms

        public TelaInicial()
        {
            InitializeComponent();
            CenterToScreen(); // Inicia o form centralizado

            // Conectando com o banco de dados ao iniciar
            GameRepository.Conectar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        public void abrirBuscarJogos(object obj) // método para a iniciar outro form
        {
            Application.Run(new BuscarJogos()); // inicia o form BuscarJogos
        }

        public void abrirMeusFavoritos(object obj) // método para a iniciar outro form
        {
            Application.Run(new MeusFavoritos()); // inicia o form MeusFavoritos
        }

        private void btnBuscarJogos_Click(object sender, EventArgs e)
        {
            this.Close(); // fechando tela atual
            t1 = new Thread(abrirBuscarJogos); // instanciando o objeto da Thread e referencando o método que será utilizado
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start(); // executando a thread t1 (executando o form BuscarJogos)
        }

        private void btnMeusFavoritos_Click(object sender, EventArgs e)
        {
            this.Close(); // fechando tela atual
            t1 = new Thread(abrirMeusFavoritos); // instanciando o objeto da Thread e referencando o método que será utilizado
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start(); // executando a thread t1 (executando o form MeusFavoritos)
        }

        private void TelaInicial_Load_1(object sender, EventArgs e)
        {

        }
    }
}
