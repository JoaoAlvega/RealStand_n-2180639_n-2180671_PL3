using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Real_Stand
{
    public partial class Gestao_Oficina : Form
    {
        private Model_Real_StandContainer minhaOficina;

        public Gestao_Oficina()
        {
            InitializeComponent();
        }

        private void Gestao_Oficina_Load(object sender, EventArgs e)
        {
            minhaOficina = new Model_Real_StandContainer();
            LerDados();
        }
        private void LerDados()
        {
            listBoxClientes.DataSource = minhaOficina.Clientes.ToList<Cliente>();
            
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Pagina_Principal pagina_Principal = (Pagina_Principal)Tag;
            pagina_Principal.Show();
            Close();
        }

        //Clientes-----------------------------------------------------------------------------------------------------------------------------------------------

        //Listar Clientes
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            
            textBoxMostraNome.Text = clienteSelecionado.Nome;   

            listBoxCarros.DataSource = clienteSelecionado.CarrosOficina.ToList();
        }
            
        //Remover Clientes
        private void buttonApagarClientes_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            minhaOficina.Clientes.Remove(clienteSelecionado);

            minhaOficina.SaveChanges();

            listBoxClientes.DataSource = minhaOficina.Clientes.ToList();
        }

        //Carros-----------------------------------------------------------------------------------------------------------------------------------------------

        //Adicionar Carro
        private void buttonAdicionarCarro_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;


            Adicionar_Carro_Oficina adicionar_Carro_Oficina = new Adicionar_Carro_Oficina(clienteSelecionado, minhaOficina);
            adicionar_Carro_Oficina.Tag = this;
            adicionar_Carro_Oficina.Show(this);
            Hide();

            CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;

        }
            
        //Listar Carro
        private void listBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
            listBoxServicos.DataSource = carroSelecionado.Servicos.ToList();
        }

        //Remover Carro
        private void buttonApagarCarros_Click(object sender, EventArgs e)
        {
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;

            minhaOficina.Carros.Remove(carroSelecionado);

            minhaOficina.SaveChanges();

            listBoxClientes.DataSource = minhaOficina.Carros.ToList();
        }

        //Serviços-----------------------------------------------------------------------------------------------------------------------------------------------

        //Adicionar Serviços
        private void buttonAdicionarServico_Click(object sender, EventArgs e)
        {
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;


            Adicionar_Servico_Oficina adicionar_Servico_Oficina = new Adicionar_Servico_Oficina(carroSelecionado, minhaOficina);
            adicionar_Servico_Oficina.Tag = this;
            adicionar_Servico_Oficina.Show(this);
            Hide();
        }
            
        //Listar Serviços
        private void listBoxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;
            listBoxParcelas.DataSource = servicoSelecionado.Parcelas.ToList();
        }

        //Remover Serviços
        private void buttonServiços_Click(object sender, EventArgs e)
        {
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;

            minhaOficina.Servicos.Remove(servicoSelecionado);
            minhaOficina.SaveChanges();

            listBoxClientes.DataSource = minhaOficina.Servicos.ToList();
        }


        //Parcelas-----------------------------------------------------------------------------------------------------------------------------------------------


        //Adicionar Parcelas
        private void buttonAdicionarParcela_Click(object sender, EventArgs e)
        {
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;

            Parcela parcela = new Parcela(int.Parse(textBoxValor.Text),textBoxDescricao.Text);

            servicoSelecionado.Parcelas.Add(parcela);

            textBoxValor.Text = "";
            textBoxDescricao.Text = "";

            minhaOficina.SaveChanges();
            listBoxParcelas.DataSource = servicoSelecionado.Parcelas.ToList();
        }
            
        //Listar Parcelas
        private void listBoxParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parcela parcelaSelecionado = (Parcela)listBoxParcelas.SelectedItem;
        }

        //Remover Parcelas
        private void buttonParcelas_Click(object sender, EventArgs e)
        {
            Parcela parcelaSelecionado = (Parcela)listBoxParcelas.SelectedItem;

            minhaOficina.Parcelas.Remove(parcelaSelecionado);
            minhaOficina.SaveChanges();

            listBoxClientes.DataSource = minhaOficina.Parcelas.ToList();
        }

        //Apenas permite a introdução de numeros
        private void textBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
