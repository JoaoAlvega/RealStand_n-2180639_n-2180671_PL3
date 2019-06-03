using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Stand
{
    public partial class Gestao_Aluguer : Form
    {
        private Model_Real_StandContainer minhaOficina;
        public Gestao_Aluguer()
        {
            InitializeComponent();
        }

        private void Gestao_Aluguer_Load(object sender, EventArgs e)
        {
            minhaOficina = new Model_Real_StandContainer();
            LerDados();
        }
        private void LerDados()
        {
            listBoxClientes.DataSource = minhaOficina.Clientes.ToList<Cliente>();
            listBoxCarroAluguer.DataSource = minhaOficina.Carros.OfType<CarroAluguer>().ToList();
            listBoxAluguer.DataSource = minhaOficina.Alugueres.OfType<Aluguer>().ToList();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Pagina_Principal pagina_Principal = (Pagina_Principal)Tag;
            pagina_Principal.Show();
            Close();
        }
        //Clientes-----------------------------------------------------------------------------------------------------------------------------------------------
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            textBoxMostraNome.Text = clienteSelecionado.Nome;
        }

        private void buttonCarroAluguer_Click(object sender, EventArgs e)
        {
            Adicionar_Carro_Aluguer adicionar_Carro_Aluguer = new Adicionar_Carro_Aluguer();
            adicionar_Carro_Aluguer.Tag = this;
            adicionar_Carro_Aluguer.Show(this);
            Hide();

            adicionar_Carro_Aluguer.FormClosed += new FormClosedEventHandler(Form_Closed);
        }
        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            listBoxClientes.DataSource = minhaOficina.Clientes.ToList<Cliente>();
            listBoxCarroAluguer.DataSource = minhaOficina.Carros.OfType<CarroAluguer>().ToList();

        }
        //Alugueres-----------------------------------------------------------------------------------------------------------------------------------------------
        private void buttonAluguer_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            CarroAluguer carroSelecionado = (CarroAluguer)listBoxCarroAluguer.SelectedItem;

            Adicionar_Aluguer adicionar_Aluguer = new Adicionar_Aluguer(clienteSelecionado, carroSelecionado, minhaOficina);
            adicionar_Aluguer.Tag = this;
            adicionar_Aluguer.Show(this);
            Hide();

            adicionar_Aluguer.FormClosed += new FormClosedEventHandler(Form_Closed);
        }

        private void listBoxAluguer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBoxClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            textBoxMostraNome.Text = clienteSelecionado.Nome;
        }
    }
}
