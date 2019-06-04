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
                if (textBoxModelo.Text.Length == 0 || textBoxNumChassis.Text.Length == 0 || comboBoxMarca.SelectedItem == null || comboBoxCombustivel.SelectedItem == null || comboBoxEstado.SelectedItem == null)
                {
                    MessageBox.Show("Caixa de Texto vazia", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (textBoxNumChassis.Text.Length != 17)
                {
                    MessageBox.Show("O número de chassis/quadro têm de conter 17 digitos", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string MatriculaCompleta = textBoxMatricula.Text + "-" + textBoxMatricula2.Text + "-" + textBoxMatricula3.Text;

                    CarroAluguer carroAluguer = new CarroAluguer(textBoxNumChassis.Text, comboBoxMarca.SelectedItem.ToString(), textBoxModelo.Text, comboBoxCombustivel.SelectedItem.ToString(),
            comboBoxEstado.SelectedItem.ToString(),MatriculaCompleta);
                    minhaOficina.Carros.Add(carroAluguer);
                    

                    minhaOficina.SaveChanges();
                    MessageBox.Show("Alteracões Guardadas", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                return;
            }
        }

        //Apenas permite a introdução de letras maiusculas
        private void textBoxMatricula_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }

        private const int MaxCharsPerRow = 2;
        private const int MaxLines = 1;

        private void textBoxMatricula_TextChanged(object sender, EventArgs e)
        {
            string[] lines = textBoxMatricula.Lines;
            var newLines = new List<string>();
            for (int i = 0; i < lines.Length && i < MaxLines; i++)
            {
                newLines.Add(lines[i].Substring(0, Math.Min(lines[i].Length, MaxCharsPerRow)));
            }
            textBoxMatricula.Lines = newLines.ToArray();
        }

        private void textBoxMatricula2_TextChanged(object sender, EventArgs e)
        {
            string[] lines = textBoxMatricula2.Lines;
            var newLines = new List<string>();
            for (int i = 0; i < lines.Length && i < MaxLines; i++)
            {
                newLines.Add(lines[i].Substring(0, Math.Min(lines[i].Length, MaxCharsPerRow)));
            }
            textBoxMatricula2.Lines = newLines.ToArray();
        }

        private void textBoxMatricula3_TextChanged(object sender, EventArgs e)
        {
            string[] lines = textBoxMatricula3.Lines;
            var newLines = new List<string>();
            for (int i = 0; i < lines.Length && i < MaxLines; i++)
            {
                newLines.Add(lines[i].Substring(0, Math.Min(lines[i].Length, MaxCharsPerRow)));
            }
            textBoxMatricula3.Lines = newLines.ToArray();
        }


    }
}
