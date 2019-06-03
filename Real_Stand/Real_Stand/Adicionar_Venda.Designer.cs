namespace Real_Stand
{
    partial class Adicionar_Venda
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
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.labelDtaFim = new System.Windows.Forms.Label();
            this.labelTipoServico = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(172, 145);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(218, 20);
            this.textBoxValor.TabIndex = 160;
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(172, 197);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(218, 20);
            this.dateTimePickerData.TabIndex = 159;
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(172, 171);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(218, 20);
            this.textBoxEstado.TabIndex = 157;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(110, 174);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(43, 13);
            this.labelData.TabIndex = 156;
            this.labelData.Text = "Estado:";
            // 
            // labelDtaFim
            // 
            this.labelDtaFim.AutoSize = true;
            this.labelDtaFim.Location = new System.Drawing.Point(120, 203);
            this.labelDtaFim.Name = "labelDtaFim";
            this.labelDtaFim.Size = new System.Drawing.Size(33, 13);
            this.labelDtaFim.TabIndex = 155;
            this.labelDtaFim.Text = "Data:";
            // 
            // labelTipoServico
            // 
            this.labelTipoServico.AutoSize = true;
            this.labelTipoServico.Location = new System.Drawing.Point(119, 145);
            this.labelTipoServico.Name = "labelTipoServico";
            this.labelTipoServico.Size = new System.Drawing.Size(34, 13);
            this.labelTipoServico.TabIndex = 153;
            this.labelTipoServico.Text = "Valor:";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(315, 223);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 152;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(437, 414);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 151;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // Adicionar_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelDtaFim);
            this.Controls.Add(this.labelTipoServico);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonVoltar);
            this.Name = "Adicionar_Venda";
            this.Text = "AdicionarVenda";
            this.Load += new System.EventHandler(this.Adicionar_Venda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelDtaFim;
        private System.Windows.Forms.Label labelTipoServico;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonVoltar;
    }
}