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
    public partial class Adicionar_Carro_Venda : Form
    {
        private Model_Real_StandContainer minhaOficina;
        public Adicionar_Carro_Venda()
        {
            InitializeComponent();
        }

        private void Adicionar_Carro_Venda_Load(object sender, EventArgs e)
        {
            minhaOficina = new Model_Real_StandContainer();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Gestao_Vendas gestao_Vendas = (Gestao_Vendas)Tag;
            gestao_Vendas.Show();
            Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

                if (textBoxMarca.Text.Length == 0 || textBoxModelo.Text.Length == 0 || textBoxNumChassis.Text.Length == 0)
                {
                    MessageBox.Show("Caixa de Texto vazia");
                }
                else
                {

                    CarroVenda carroVenda = new CarroVenda(textBoxNumChassis.Text, textBoxMarca.Text, textBoxModelo.Text, comboBoxCombustivel.SelectedItem.ToString(), textBoxExtras.Text);

                    minhaOficina.Carros.Add(carroVenda);

                    minhaOficina.SaveChanges();
                    MessageBox.Show("Alteracões Guardadas");
                }
            
                
        }
    }
}
