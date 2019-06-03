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
    public partial class Gestao_Vendas : Form
    {
        private Model_Real_StandContainer minhaOficina;
        public Gestao_Vendas()
        {
            InitializeComponent();
        }

        private void Gestao_Vendas_Load(object sender, EventArgs e)
        {
            minhaOficina = new Model_Real_StandContainer();
            LerDados();
        }
        private void LerDados()
        {
            listBoxClientes.DataSource = minhaOficina.Clientes.ToList<Cliente>();
        }
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Pagina_Principal pagina_Principal = (Pagina_Principal)Tag;
            pagina_Principal.Show();
            Close();
        }
        //Clientes-----------------------------------------------------------------------------------------------------------------------------------------------
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            textBoxMostraNome.Text = clienteSelecionado.Nome;
        }
    }
}
