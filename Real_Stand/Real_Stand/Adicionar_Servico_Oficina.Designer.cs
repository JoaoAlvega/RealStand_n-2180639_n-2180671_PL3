namespace Real_Stand
{
    partial class Adicionar_Servico_Oficina
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
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.labelDtaFim = new System.Windows.Forms.Label();
            this.labelDtaInicio = new System.Windows.Forms.Label();
            this.labelTipoServico = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFim = new System.Windows.Forms.DateTimePicker();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.labelCarro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(314, 221);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 111;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(436, 415);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 110;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // labelDtaFim
            // 
            this.labelDtaFim.AutoSize = true;
            this.labelDtaFim.Location = new System.Drawing.Point(100, 198);
            this.labelDtaFim.Name = "labelDtaFim";
            this.labelDtaFim.Size = new System.Drawing.Size(65, 13);
            this.labelDtaFim.TabIndex = 115;
            this.labelDtaFim.Text = "Data Saída:";
            // 
            // labelDtaInicio
            // 
            this.labelDtaInicio.AutoSize = true;
            this.labelDtaInicio.Location = new System.Drawing.Point(92, 172);
            this.labelDtaInicio.Name = "labelDtaInicio";
            this.labelDtaInicio.Size = new System.Drawing.Size(73, 13);
            this.labelDtaInicio.TabIndex = 114;
            this.labelDtaInicio.Text = "Data Entrada:";
            // 
            // labelTipoServico
            // 
            this.labelTipoServico.AutoSize = true;
            this.labelTipoServico.Location = new System.Drawing.Point(80, 145);
            this.labelTipoServico.Name = "labelTipoServico";
            this.labelTipoServico.Size = new System.Drawing.Size(85, 13);
            this.labelTipoServico.TabIndex = 112;
            this.labelTipoServico.Text = "Tipo de Serviço:";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "PNEUS",
            "MUDANÇA DE ÓLEO E REVISÃO",
            "MECÂNICA E SERVIÇOS",
            "INSTALAÇÃO DE EQUIPAMENTOS",
            "DIAGNÓSTICOS ESPECIALIZADOS",
            "OUTROS SERVIÇOS"});
            this.comboBoxTipo.Location = new System.Drawing.Point(171, 142);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(218, 21);
            this.comboBoxTipo.TabIndex = 119;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(171, 169);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(218, 20);
            this.dateTimePickerInicio.TabIndex = 149;
            // 
            // dateTimePickerFim
            // 
            this.dateTimePickerFim.Location = new System.Drawing.Point(171, 198);
            this.dateTimePickerFim.Name = "dateTimePickerFim";
            this.dateTimePickerFim.Size = new System.Drawing.Size(218, 20);
            this.dateTimePickerFim.TabIndex = 150;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(279, 59);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(110, 20);
            this.textBoxModelo.TabIndex = 157;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(171, 59);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(113, 20);
            this.textBoxMarca.TabIndex = 156;
            // 
            // labelCarro
            // 
            this.labelCarro.AutoSize = true;
            this.labelCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarro.Location = new System.Drawing.Point(110, 56);
            this.labelCarro.Name = "labelCarro";
            this.labelCarro.Size = new System.Drawing.Size(52, 20);
            this.labelCarro.TabIndex = 155;
            this.labelCarro.Text = "Carro:";
            // 
            // Adicionar_Servico_Oficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.labelCarro);
            this.Controls.Add(this.dateTimePickerFim);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.labelDtaFim);
            this.Controls.Add(this.labelDtaInicio);
            this.Controls.Add(this.labelTipoServico);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonVoltar);
            this.Name = "Adicionar_Servico_Oficina";
            this.Text = "Adicionar_Servico_Oficina";
            this.Load += new System.EventHandler(this.Adicionar_Servico_Oficina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label labelDtaFim;
        private System.Windows.Forms.Label labelDtaInicio;
        private System.Windows.Forms.Label labelTipoServico;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFim;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label labelCarro;
    }
}