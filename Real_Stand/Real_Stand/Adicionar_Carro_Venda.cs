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
            try
            {
                if (textBoxModelo.Text.Length == 0 || textBoxNumChassis.Text.Length == 0 || comboBoxCombustivel.SelectedItem == null || comboBoxMarca.SelectedItem == null)
                {
                    MessageBox.Show("Caixa de Texto vazia","Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (textBoxNumChassis.Text.Length != 17)
                {
                    MessageBox.Show("O número de chassis/quadro têm de conter 17 digitos", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    CarroVenda carroVenda = new CarroVenda(textBoxNumChassis.Text, comboBoxMarca.SelectedItem.ToString(), textBoxModelo.Text, comboBoxCombustivel.SelectedItem.ToString(), textBoxExtras.Text);

                    minhaOficina.Carros.Add(carroVenda);

                    minhaOficina.SaveChanges();
                    MessageBox.Show("Alteracões Guardadas", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Erro no sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }      
        }
    }
}
