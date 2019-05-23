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
using System.Data.Entity.Validation;

namespace Real_Stand
{
    public partial class Gestao_Clientes : Form
    {
        private Model_Real_StandContainer minhaOficina;
        public Gestao_Clientes()
        {
            InitializeComponent();

            minhaOficina = new Model_Real_StandContainer();
            (from cliente in minhaOficina.Clientes
             orderby cliente.Nome
             select cliente).Load();
            clienteBindingSource.DataSource = minhaOficina.Clientes.Local.ToBindingList();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            if (nomeTextBox.Text.Length == 0 || nIFTextBox.Text.Length == 0 || moradaTextBox.Text.Length == 0 || contactoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Caixa de Texto vazia");
            }
            if (nIFTextBox.Text.Length != 9)
            {
                MessageBox.Show("Nif tem de conter 9 digitos");
            }
            if (contactoTextBox.Text.Length != 9)
            {
                MessageBox.Show("Contacto tem de conter 9 digitos");
            }
            else
            {
                Cliente cliente = new Cliente(nomeTextBox.Text, int.Parse(nIFTextBox.Text), moradaTextBox.Text, int.Parse(contactoTextBox.Text));
                minhaOficina.Clientes.Add(cliente);

                nomeTextBox.Text = "";
                nIFTextBox.Text = "";
                moradaTextBox.Text = "";
                contactoTextBox.Text = "";

                minhaOficina.SaveChanges();
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            minhaOficina.SaveChanges();
            Pagina_Principal pagina_Principal = (Pagina_Principal)Tag;
            pagina_Principal.Show();
            Close();
        }

        //Apenas permite a introdução de numeros
        private void nIFTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void contactoTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
 