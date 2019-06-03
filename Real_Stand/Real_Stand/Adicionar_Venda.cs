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
    public partial class Adicionar_Venda : Form
    {
        private Model_Real_StandContainer minhaOficina;
        private Cliente cliente;
        private CarroVenda carro;
        public Adicionar_Venda(Cliente clienteSelecionado, CarroVenda carroSelecionado, Model_Real_StandContainer oficina)
        {
            InitializeComponent();
            cliente = clienteSelecionado;
            carro = carroSelecionado;
            minhaOficina = oficina;
        }
        private void Adicionar_Venda_Load(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Gestao_Vendas gestao_Vendas = (Gestao_Vendas)Tag;
            gestao_Vendas.Show();
            Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
                Venda venda = new Venda(textBoxValor.Text, textBoxEstado.Text, dateTimePickerData.Value.ToString());

                venda.CarroVenda = carro;
                cliente.Vendas.Add(venda);

                minhaOficina.SaveChanges();
                MessageBox.Show("Alteracões Guardadas");
        }
    }
}
