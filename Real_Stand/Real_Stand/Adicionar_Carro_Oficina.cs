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
    public partial class Adicionar_Carro_Oficina : Form
    {
        private Model_Real_StandContainer minhaOficina;
        private Cliente cliente;
        
        //Verificadores da matricula-----------------------------------------------------------------------------------------------------------
        public bool contemLetras(string texto)
        {
            if (texto.Where(c => char.IsLetter(c)).Count() != 2)
                return true;
            else
                return false;
        }

        public bool contemNumeros(string texto)
        {
            if (texto.Where(c => char.IsNumber(c)).Count() != 4)
                return true;
            else
                return false;
        }

        public Adicionar_Carro_Oficina(Cliente clienteSelecionado, Model_Real_StandContainer oficina)
        {
            InitializeComponent();
            cliente = clienteSelecionado;
            minhaOficina = oficina;
        }
        private void Adicionar_Carro_Oficina_Load(object sender, EventArgs e)
        {
            textBoxMostraNome.Text = cliente.Nome;
            textBoxNif.Text = cliente.NIF.ToString();
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
                if (textBoxNumChassis.Text.Length == 0 ||textBoxModelo.Text.Length == 0 || textBoxMatricula.Text.Length == 0 || textBoxKms.Text.Length == 0 || comboBoxMarca.SelectedItem == null || comboBoxCombustivel.SelectedItem == null)
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

                    CarroOficina carroOficina = new CarroOficina(textBoxNumChassis.Text, comboBoxMarca.SelectedItem.ToString(), textBoxModelo.Text, comboBoxCombustivel.SelectedItem.ToString(), MatriculaCompleta, int.Parse(textBoxKms.Text));
                    cliente.CarrosOficina.Add(carroOficina);

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

        //Apenas permite a introdução de numeros
        private void textBoxKms_KeyPress(object sender, KeyPressEventArgs e)
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
