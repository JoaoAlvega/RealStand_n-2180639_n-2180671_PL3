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
    public partial class Adicionar_Servico_Oficina : Form
    {
        private Model_Real_StandContainer minhaOficina;
        private CarroOficina carroOficina;

        public Adicionar_Servico_Oficina(CarroOficina carroSelecionado, Model_Real_StandContainer oficina)
        {
            InitializeComponent();
            carroOficina = carroSelecionado;
            minhaOficina = oficina;
        }

        private void Adicionar_Servico_Oficina_Load(object sender, EventArgs e)
        {
            textBoxMarca.Text = carroOficina.Marca;
            textBoxModelo.Text = carroOficina.Modelo;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Gestao_Oficina gestao_Oficina = (Gestao_Oficina)Tag;
            gestao_Oficina.Show();
            Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTipo.SelectedItem.ToString() == null)
                {
                    MessageBox.Show("Caixa de Texto vazia", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    Servico servico = new Servico(dateTimePickerInicio.Value.ToString(), dateTimePickerFim.Value.ToString(), comboBoxTipo.SelectedItem.ToString());
                    carroOficina.Servicos.Add(servico);

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
