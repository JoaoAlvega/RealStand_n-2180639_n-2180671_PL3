﻿using System;
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
            labelCliente.Text = cliente.Nome.ToString();
        }
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Gestao_Oficina gestao_Oficina = (Gestao_Oficina)Tag;
            gestao_Oficina.Show();
            Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxNumChassis.Text.Length == 0 || textBoxMarca.Text.Length == 0 || textBoxModelo.Text.Length == 0 || textBoxCombustivel.Text.Length == 0 || textBoxMatricula.Text.Length == 0 || textBoxKms.Text.Length == 0)
            {
                MessageBox.Show("Caixa de Texto vazia");
            }
            if (textBoxNumChassis.Text.Length != 17)
            {
                MessageBox.Show("O número de chassis/quadro têm de conter 17 digitos");
            }
            if (this.contemLetras(textBoxMatricula.Text) && this.contemNumeros(textBoxMatricula.Text) && textBoxMatricula.Text.Length != 8)
            {
                MessageBox.Show("Matrícula tem de conter 2 Letras, 4 Numeros e estar no seguinte formato 00:00:00");
            }
            else
            {
                CarroOficina carroOficina = new CarroOficina(textBoxNumChassis.Text, textBoxMarca.Text, textBoxModelo.Text, textBoxCombustivel.Text, textBoxMatricula.Text, int.Parse(textBoxKms.Text));
                cliente.CarrosOficina.Add(carroOficina);

                textBoxNumChassis.Text = "";
                textBoxMarca.Text = "";
                textBoxModelo.Text = "";
                textBoxCombustivel.Text = "";
                textBoxMatricula.Text = "";
                textBoxKms.Text = "";

                minhaOficina.SaveChanges();
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
    }
}