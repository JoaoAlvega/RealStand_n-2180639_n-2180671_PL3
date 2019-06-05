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
    public partial class Gestao_Oficina : Form
    {
        private Model_Real_StandContainer minhaOficina;

        public Gestao_Oficina()
        {
            InitializeComponent();
        }

        private void Gestao_Oficina_Load(object sender, EventArgs e)
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

        //Listar Clientes
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

                textBoxMostraNome.Text = clienteSelecionado.Nome;

                listBoxCarros.DataSource = clienteSelecionado.CarrosOficina.ToList();

                labelTotalGasto.Text = "00.00";

                textBoxMarca.Text = "";
                textBoxModelo.Text = "";
            }
            catch
            {
                return;
            }

        }
            
        //Remover Clientes
        private void buttonApagarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

                if (clienteSelecionado == null)
                    return;

                minhaOficina.Clientes.Remove(clienteSelecionado);

                minhaOficina.SaveChanges();

                listBoxClientes.DataSource = minhaOficina.Clientes.ToList();
            }
            catch
            {
                MessageBox.Show("Erro no sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        //Carros-----------------------------------------------------------------------------------------------------------------------------------------------

        //Adicionar Carro
        private void buttonAdicionarCarro_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;


            Adicionar_Carro_Oficina adicionar_Carro_Oficina = new Adicionar_Carro_Oficina(clienteSelecionado, minhaOficina);
            adicionar_Carro_Oficina.Tag = this;
            adicionar_Carro_Oficina.Show(this);
            Hide();

            adicionar_Carro_Oficina.FormClosed += new FormClosedEventHandler(Form_Closed);
        }
        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            listBoxCarros.DataSource = clienteSelecionado.CarrosOficina.ToList();
            
        }

        //Listar Carro
        private void listBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
                if (carroSelecionado == null)
                {
                    Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
                    listBoxCarros.DataSource = clienteSelecionado.CarrosOficina.ToList();
                }
                else
                {
                    listBoxServicos.DataSource = carroSelecionado.Servicos.ToList();
                    textBoxMarca.Text = carroSelecionado.Marca;
                    textBoxModelo.Text = carroSelecionado.Modelo;
                }
            }
            catch
            {
                return;
            }
            
        }

        //Remover Carro
        private void buttonApagarCarros_Click(object sender, EventArgs e)
        {
            try
            {
                CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;

                if (carroSelecionado == null)
                    return;

                minhaOficina.Carros.Remove(carroSelecionado);

                minhaOficina.SaveChanges();

                listBoxClientes.DataSource = minhaOficina.Carros.ToList();
            }
            catch
            {
                MessageBox.Show("Erro no sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        //Serviços-----------------------------------------------------------------------------------------------------------------------------------------------

        //Adicionar Serviços
        private void buttonAdicionarServico_Click(object sender, EventArgs e)
        {
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;


            Adicionar_Servico_Oficina adicionar_Servico_Oficina = new Adicionar_Servico_Oficina(carroSelecionado, minhaOficina);
            adicionar_Servico_Oficina.Tag = this;
            adicionar_Servico_Oficina.Show(this);
            Hide();
        }
            
        //Listar Serviços
        private void listBoxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;

                if (servicoSelecionado == null)
                {
                    return;
                }
                else
                {
                    listBoxParcelas.DataSource = servicoSelecionado.Parcelas.ToList();
                }
            }
            catch
            {
                return;
            }
        }

        //Remover Serviços
        private void buttonServiços_Click(object sender, EventArgs e)
        {
            try
            {
                Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;

                if (servicoSelecionado == null)
                    return;

                minhaOficina.Servicos.Remove(servicoSelecionado);
                minhaOficina.SaveChanges();

                listBoxClientes.DataSource = minhaOficina.Servicos.ToList();
            }
            catch
            {
                MessageBox.Show("Erro no sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        //Parcelas-----------------------------------------------------------------------------------------------------------------------------------------------


        //Adicionar Parcelas
        private void buttonAdicionarParcela_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxValor.Text == null || textBoxDescricao.Text == null)
                {
                    MessageBox.Show("Caixa de Texto vazia", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;

                    Parcela parcela = new Parcela(int.Parse(textBoxValor.Text), textBoxDescricao.Text);

                    servicoSelecionado.Parcelas.Add(parcela);


                    minhaOficina.SaveChanges();
                    listBoxParcelas.DataSource = servicoSelecionado.Parcelas.ToList();
                }
            }
            catch
            {
                MessageBox.Show("Erro no sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
            
        //Listar Parcelas
        private void listBoxParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Parcela parcelaSelecionado = (Parcela)listBoxParcelas.SelectedItem;
            }
            catch
            {
                return;
            }
        }

        //Remover Parcelas
        private void buttonParcelas_Click(object sender, EventArgs e)
        {
            try
            {
                Parcela parcelaSelecionado = (Parcela)listBoxParcelas.SelectedItem;

                if (parcelaSelecionado == null)
                    return;

                minhaOficina.Parcelas.Remove(parcelaSelecionado);
                minhaOficina.SaveChanges();

                listBoxClientes.DataSource = minhaOficina.Parcelas.ToList();
            }
            catch
            {
                return;
            }

        }

        //Apenas permite a introdução de numeros
        private void textBoxValor_KeyPress(object sender, KeyPressEventArgs e)
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
