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

        private void pictureBoxGestaoAluguer_Click(object sender, EventArgs e)
        {
            Gestao_Aluguer gestao_Aluguer = new Gestao_Aluguer();
            gestao_Aluguer.Tag = this;
            gestao_Aluguer.Show(this);
            Hide();
        }

        private void pictureBoxGestaoVendas_Click(object sender, EventArgs e)
        {
            Gestao_Vendas gestao_Vendas = new Gestao_Vendas();
            gestao_Vendas.Tag = this;
            gestao_Vendas.Show(this);
            Hide();
        }
    }
}
