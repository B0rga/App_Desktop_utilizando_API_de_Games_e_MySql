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
        }        

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            // Conectando com o banco de dados ao iniciar
            GameRepository.Conectar();
        }

        // método para a iniciar outro form
        public void abrirBuscarJogos(object obj) 
        {
            Application.Run(new BuscarJogos()); // inicia o form BuscarJogos
        }

        // método para a iniciar outro form
        public void abrirMeusFavoritos(object obj) 
        {
            Application.Run(new MeusFavoritos()); // inicia o form MeusFavoritos
        }

        // botão do menu que leva até a tela de buscar jogos
        private void btnBuscarJogos_Click(object sender, EventArgs e)
        {
            this.Close(); // fechando tela atual
            t1 = new Thread(abrirBuscarJogos); // instanciando o objeto da Thread e referencando o método que será utilizado
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start(); // executando a thread t1 (executando o form BuscarJogos)
        }

        // botão do menu que leva até a tela de favoritos
        private void btnMeusFavoritos_Click(object sender, EventArgs e)
        {
            this.Close(); // fechando tela atual
            t1 = new Thread(abrirMeusFavoritos); // instanciando o objeto da Thread e referencando o método que será utilizado
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start(); // executando a thread t1 (executando o form MeusFavoritos)
        }
    }
}
