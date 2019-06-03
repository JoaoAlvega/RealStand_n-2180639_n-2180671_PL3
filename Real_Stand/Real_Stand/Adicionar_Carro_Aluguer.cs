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
    public partial class Adicionar_Carro_Aluguer : Form
    {
        private Model_Real_StandContainer minhaOficina;

        public Adicionar_Carro_Aluguer()
        {
            InitializeComponent();
        }
        private void Adicionar_Carro_Aluguer_Load(object sender, EventArgs e)
        {
            minhaOficina = new Model_Real_StandContainer();
        }
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Gestao_Aluguer gestao_Aluguer = (Gestao_Aluguer)Tag;
            gestao_Aluguer.Show();
            Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxMarca.Text.Length == 0 || textBoxModelo.Text.Length == 0 || textBoxNumChassis.Text.Length == 0)
                {
                    MessageBox.Show("Caixa de Texto vazia");
                }
                else
                {
                    string MatriculaCompleta = textBoxMatricula.Text + "-" + textBoxMatricula2.Text + "-" + textBoxMatricula3.Text;

                    CarroAluguer carroAluguer = new CarroAluguer(textBoxNumChassis.Text, textBoxMarca.Text, textBoxModelo.Text, comboBoxCombustivel.SelectedItem.ToString(),
            comboBoxEstado.SelectedItem.ToString(),MatriculaCompleta);
                    minhaOficina.Carros.Add(carroAluguer);
                    

                    minhaOficina.SaveChanges();
                    MessageBox.Show("Alteracões Guardadas");
                }
            }
            catch
            {
                return;
            }
        }

        
    }
}
