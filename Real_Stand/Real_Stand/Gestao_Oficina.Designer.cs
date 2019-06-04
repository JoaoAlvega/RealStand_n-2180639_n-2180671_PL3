namespace Real_Stand
{
    partial class Gestao_Oficina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.labelTotalGasto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAdicionarParcela = new System.Windows.Forms.Button();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxParcelas = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAdicionarServico = new System.Windows.Forms.Button();
            this.listBoxServicos = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdicionarCarro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMostraNome = new System.Windows.Forms.TextBox();
            this.labelMostraNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonApagarClientes = new System.Windows.Forms.Button();
            this.buttonApagarCarros = new System.Windows.Forms.Button();
            this.buttonServiços = new System.Windows.Forms.Button();
            this.buttonParcelas = new System.Windows.Forms.Button();
            this.labelCarro = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(10, 43);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(142, 394);
            this.listBoxClientes.TabIndex = 109;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(181, 124);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(144, 264);
            this.listBoxCarros.TabIndex = 108;
            this.listBoxCarros.SelectedIndexChanged += new System.EventHandler(this.listBoxCarros_SelectedIndexChanged);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(825, 412);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 107;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // labelTotalGasto
            // 
            this.labelTotalGasto.AutoSize = true;
            this.labelTotalGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalGasto.Location = new System.Drawing.Point(568, 45);
            this.labelTotalGasto.Name = "labelTotalGasto";
            this.labelTotalGasto.Size = new System.Drawing.Size(62, 20);
            this.labelTotalGasto.TabIndex = 105;
            this.labelTotalGasto.Text = "€ 00.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(568, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 104;
            this.label10.Text = "Total Gasto:";
            // 
            // buttonAdicionarParcela
            // 
            this.buttonAdicionarParcela.Location = new System.Drawing.Point(572, 396);
            this.buttonAdicionarParcela.Name = "buttonAdicionarParcela";
            this.buttonAdicionarParcela.Size = new System.Drawing.Size(247, 42);
            this.buttonAdicionarParcela.TabIndex = 103;
            this.buttonAdicionarParcela.Text = "Adicionar Parcela";
            this.buttonAdicionarParcela.UseVisualStyleBackColor = true;
            this.buttonAdicionarParcela.Click += new System.EventHandler(this.buttonAdicionarParcela_Click);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(719, 371);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor.TabIndex = 102;
            this.textBoxValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValor_KeyPress);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(572, 371);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(141, 20);
            this.textBoxDescricao.TabIndex = 101;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(569, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 13);
            this.label9.TabIndex = 100;
            this.label9.Text = "Criar Nova (Descrição - Valor)";
            // 
            // listBoxParcelas
            // 
            this.listBoxParcelas.FormattingEnabled = true;
            this.listBoxParcelas.Location = new System.Drawing.Point(572, 124);
            this.listBoxParcelas.Name = "listBoxParcelas";
            this.listBoxParcelas.Size = new System.Drawing.Size(247, 225);
            this.listBoxParcelas.TabIndex = 96;
            this.listBoxParcelas.SelectedIndexChanged += new System.EventHandler(this.listBoxParcelas_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 95;
            this.label8.Text = "Parcelas";
            // 
            // buttonAdicionarServico
            // 
            this.buttonAdicionarServico.Location = new System.Drawing.Point(349, 396);
            this.buttonAdicionarServico.Name = "buttonAdicionarServico";
            this.buttonAdicionarServico.Size = new System.Drawing.Size(192, 42);
            this.buttonAdicionarServico.TabIndex = 94;
            this.buttonAdicionarServico.Text = "Adicionar Serviço";
            this.buttonAdicionarServico.UseVisualStyleBackColor = true;
            this.buttonAdicionarServico.Click += new System.EventHandler(this.buttonAdicionarServico_Click);
            // 
            // listBoxServicos
            // 
            this.listBoxServicos.FormattingEnabled = true;
            this.listBoxServicos.Location = new System.Drawing.Point(349, 124);
            this.listBoxServicos.Name = "listBoxServicos";
            this.listBoxServicos.Size = new System.Drawing.Size(192, 264);
            this.listBoxServicos.TabIndex = 92;
            this.listBoxServicos.SelectedIndexChanged += new System.EventHandler(this.listBoxServicos_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Serviços";
            // 
            // buttonAdicionarCarro
            // 
            this.buttonAdicionarCarro.Location = new System.Drawing.Point(181, 396);
            this.buttonAdicionarCarro.Name = "buttonAdicionarCarro";
            this.buttonAdicionarCarro.Size = new System.Drawing.Size(142, 42);
            this.buttonAdicionarCarro.TabIndex = 90;
            this.buttonAdicionarCarro.Text = "Adicionar Carro";
            this.buttonAdicionarCarro.UseVisualStyleBackColor = true;
            this.buttonAdicionarCarro.Click += new System.EventHandler(this.buttonAdicionarCarro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Carros";
            // 
            // textBoxMostraNome
            // 
            this.textBoxMostraNome.Location = new System.Drawing.Point(239, 24);
            this.textBoxMostraNome.Name = "textBoxMostraNome";
            this.textBoxMostraNome.Size = new System.Drawing.Size(302, 20);
            this.textBoxMostraNome.TabIndex = 87;
            // 
            // labelMostraNome
            // 
            this.labelMostraNome.AutoSize = true;
            this.labelMostraNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostraNome.Location = new System.Drawing.Point(178, 22);
            this.labelMostraNome.Name = "labelMostraNome";
            this.labelMostraNome.Size = new System.Drawing.Size(55, 20);
            this.labelMostraNome.TabIndex = 85;
            this.labelMostraNome.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Lista de Clientes";
            // 
            // buttonApagarClientes
            // 
            this.buttonApagarClientes.Location = new System.Drawing.Point(10, 415);
            this.buttonApagarClientes.Name = "buttonApagarClientes";
            this.buttonApagarClientes.Size = new System.Drawing.Size(142, 23);
            this.buttonApagarClientes.TabIndex = 110;
            this.buttonApagarClientes.Text = "Apagar";
            this.buttonApagarClientes.UseVisualStyleBackColor = true;
            this.buttonApagarClientes.Click += new System.EventHandler(this.buttonApagarClientes_Click);
            // 
            // buttonApagarCarros
            // 
            this.buttonApagarCarros.Location = new System.Drawing.Point(181, 365);
            this.buttonApagarCarros.Name = "buttonApagarCarros";
            this.buttonApagarCarros.Size = new System.Drawing.Size(144, 23);
            this.buttonApagarCarros.TabIndex = 111;
            this.buttonApagarCarros.Text = "Apagar";
            this.buttonApagarCarros.UseVisualStyleBackColor = true;
            this.buttonApagarCarros.Click += new System.EventHandler(this.buttonApagarCarros_Click);
            // 
            // buttonServiços
            // 
            this.buttonServiços.Location = new System.Drawing.Point(349, 365);
            this.buttonServiços.Name = "buttonServiços";
            this.buttonServiços.Size = new System.Drawing.Size(192, 23);
            this.buttonServiços.TabIndex = 112;
            this.buttonServiços.Text = "Apagar";
            this.buttonServiços.UseVisualStyleBackColor = true;
            this.buttonServiços.Click += new System.EventHandler(this.buttonServiços_Click);
            // 
            // buttonParcelas
            // 
            this.buttonParcelas.Location = new System.Drawing.Point(572, 326);
            this.buttonParcelas.Name = "buttonParcelas";
            this.buttonParcelas.Size = new System.Drawing.Size(247, 23);
            this.buttonParcelas.TabIndex = 113;
            this.buttonParcelas.Text = "Apagar";
            this.buttonParcelas.UseVisualStyleBackColor = true;
            this.buttonParcelas.Click += new System.EventHandler(this.buttonParcelas_Click);
            // 
            // labelCarro
            // 
            this.labelCarro.AutoSize = true;
            this.labelCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarro.Location = new System.Drawing.Point(178, 50);
            this.labelCarro.Name = "labelCarro";
            this.labelCarro.Size = new System.Drawing.Size(52, 20);
            this.labelCarro.TabIndex = 114;
            this.labelCarro.Text = "Carro:";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(239, 50);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(155, 20);
            this.textBoxMarca.TabIndex = 115;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(386, 50);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(155, 20);
            this.textBoxModelo.TabIndex = 116;
            // 
            // Gestao_Oficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.labelCarro);
            this.Controls.Add(this.buttonParcelas);
            this.Controls.Add(this.buttonServiços);
            this.Controls.Add(this.buttonApagarCarros);
            this.Controls.Add(this.buttonApagarClientes);
            this.Controls.Add(this.listBoxClientes);
            this.Controls.Add(this.listBoxCarros);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.labelTotalGasto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonAdicionarParcela);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBoxParcelas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonAdicionarServico);
            this.Controls.Add(this.listBoxServicos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAdicionarCarro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMostraNome);
            this.Controls.Add(this.labelMostraNome);
            this.Controls.Add(this.label2);
            this.Name = "Gestao_Oficina";
            this.Text = "Gestao_Oficina";
            this.Load += new System.EventHandler(this.Gestao_Oficina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label labelTotalGasto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAdicionarParcela;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxParcelas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAdicionarServico;
        private System.Windows.Forms.ListBox listBoxServicos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAdicionarCarro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMostraNome;
        private System.Windows.Forms.Label labelMostraNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonApagarClientes;
        private System.Windows.Forms.Button buttonApagarCarros;
        private System.Windows.Forms.Button buttonServiços;
        private System.Windows.Forms.Button buttonParcelas;
        private System.Windows.Forms.Label labelCarro;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxModelo;
    }
}