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
    public partial class Pagina_Principal : Form
    {
        public Pagina_Principal()
        {
            InitializeComponent();
        }

        private void pictureBoxGestaoClientes_Click(object sender, EventArgs e)
        {
            Gestao_Clientes gestao_Clientes = new Gestao_Clientes();
            gestao_Clientes.Tag = this;
            gestao_Clientes.Show(this);
            Hide();
        }

        private void pictureBoxGestaoOficina_Click(object sender, EventArgs e)
        {
            Gestao_Oficina gestao_Oficina = new Gestao_Oficina();
            gestao_Oficina.Tag = this;
            gestao_Oficina.Show(this);
            Hide();
        }
    }
}
