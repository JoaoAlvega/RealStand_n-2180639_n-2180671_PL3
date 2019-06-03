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
    public partial class Adicionar_Aluguer : Form
    {
        private Model_Real_StandContainer minhaOficina;
        private Cliente cliente;
        private CarroAluguer carro;
        public Adicionar_Aluguer(Cliente clienteSelecionado, CarroAluguer carroSelecionado, Model_Real_StandContainer oficina)
        {
            InitializeComponent();
            cliente = clienteSelecionado;
            carro = carroSelecionado;
            minhaOficina = oficina;
        }

        private void Adicionar_Aluguer_Load(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Gestao_Aluguer gestao_Aluguer = (Gestao_Aluguer)Tag;
            gestao_Aluguer.Show();
            Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Aluguer aluguer = new Aluguer(dateTimePickerInicio.Value.ToString(), dateTimePickerFim.Value.ToString(), int.Parse(textBoxValor.Text), int.Parse(textBoxKms.Text));

            aluguer.CarroAluguer = carro;
            cliente.Alugueres.Add(aluguer);

            minhaOficina.SaveChanges();
            MessageBox.Show("Alteracões Guardadas");
        }
    }
}
