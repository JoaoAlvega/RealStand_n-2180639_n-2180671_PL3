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
    public partial class Gestao_Vendas : Form
    {
        private Model_Real_StandContainer minhaOficina;
        public Gestao_Vendas()
        {
            InitializeComponent();
        }

        private void Gestao_Vendas_Load(object sender, EventArgs e)
        {
            minhaOficina = new Model_Real_StandContainer();
            LerDados();
        }
        private void LerDados()
        {
            listBoxClientes.DataSource = minhaOficina.Clientes.ToList<Cliente>();
            listBoxCarroVenda.DataSource = minhaOficina.Carros.OfType<CarroVenda>().ToList();
            listBoxVenda.DataSource = minhaOficina.Vendas.OfType<Venda>().ToList();
        }
        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            listBoxClientes.DataSource = minhaOficina.Clientes.ToList<Cliente>();
            listBoxCarroVenda.DataSource = minhaOficina.Carros.OfType<CarroVenda>().ToList();
            listBoxVenda.DataSource = minhaOficina.Vendas.OfType<Venda>().ToList();
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

        private void buttonCarroVenda_Click(object sender, EventArgs e)
        {
            Adicionar_Carro_Venda adicionar_Carro_Venda = new Adicionar_Carro_Venda();
            adicionar_Carro_Venda.Tag = this;
            adicionar_Carro_Venda.Show(this);
            Hide();

            adicionar_Carro_Venda.FormClosed += new FormClosedEventHandler(Form_Closed);
        }


        private void buttonVenda_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            CarroVenda carroSelecionado = (CarroVenda)listBoxCarroVenda.SelectedItem;

            Adicionar_Venda adicionar_Venda = new Adicionar_Venda(clienteSelecionado, carroSelecionado, minhaOficina);
            adicionar_Venda.Tag = this;
            adicionar_Venda.Show(this);
            Hide();

            adicionar_Venda.FormClosed += new FormClosedEventHandler(Form_Closed);
        }

        private void listBoxVenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

