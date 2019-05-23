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
            labelCliente.Text = carroOficina.Matricula.ToString();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Gestao_Oficina gestao_Oficina = (Gestao_Oficina)Tag;
            gestao_Oficina.Show();
            Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (comboBoxTipo.SelectedItem.ToString() == null || textBoxDtaFim.Text.Length == 0 || textBoxDtaInicio.Text.Length == 0)
            {
                MessageBox.Show("Caixa de Texto vazia");
            }
            if (textBoxDtaFim.Text.Length != 10 && textBoxDtaInicio.Text.Length != 10)
            {
                MessageBox.Show("A data tem de estar no seguinte formato: " +
                    "dd/mm/yyyy");
            }
            else
            {
                Servico servico = new Servico(textBoxDtaInicio.Text, textBoxDtaFim.Text, comboBoxTipo.SelectedItem.ToString());
                carroOficina.Servicos.Add(servico);

                textBoxDtaInicio.Text = "";
                textBoxDtaFim.Text = "";

                minhaOficina.SaveChanges();
            }
        }
    }
}
