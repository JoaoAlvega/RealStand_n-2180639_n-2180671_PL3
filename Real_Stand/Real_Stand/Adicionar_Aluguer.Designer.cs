namespace Real_Stand
{
    partial class Adicionar_Aluguer
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
            this.labelDtaFim = new System.Windows.Forms.Label();
            this.labelDtaInicio = new System.Windows.Forms.Label();
            this.labelTipoServico = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.textBoxKms = new System.Windows.Forms.TextBox();
            this.labelKms = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFim = new System.Windows.Forms.DateTimePicker();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelDtaFim
            // 
            this.labelDtaFim.AutoSize = true;
            this.labelDtaFim.Location = new System.Drawing.Point(102, 199);
            this.labelDtaFim.Name = "labelDtaFim";
            this.labelDtaFim.Size = new System.Drawing.Size(52, 13);
            this.labelDtaFim.TabIndex = 134;
            this.labelDtaFim.Text = "Data Fim:";
            // 
            // labelDtaInicio
            // 
            this.labelDtaInicio.AutoSize = true;
            this.labelDtaInicio.Location = new System.Drawing.Point(94, 173);
            this.labelDtaInicio.Name = "labelDtaInicio";
            this.labelDtaInicio.Size = new System.Drawing.Size(61, 13);
            this.labelDtaInicio.TabIndex = 133;
            this.labelDtaInicio.Text = "Data Inicio:";
            // 
            // labelTipoServico
            // 
            this.labelTipoServico.AutoSize = true;
            this.labelTipoServico.Location = new System.Drawing.Point(120, 147);
            this.labelTipoServico.Name = "labelTipoServico";
            this.labelTipoServico.Size = new System.Drawing.Size(34, 13);
            this.labelTipoServico.TabIndex = 132;
            this.labelTipoServico.Text = "Valor:";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(335, 268);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 131;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(438, 416);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 130;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // textBoxKms
            // 
            this.textBoxKms.Location = new System.Drawing.Point(173, 222);
            this.textBoxKms.Name = "textBoxKms";
            this.textBoxKms.Size = new System.Drawing.Size(218, 20);
            this.textBoxKms.TabIndex = 147;
            // 
            // labelKms
            // 
            this.labelKms.AutoSize = true;
            this.labelKms.Location = new System.Drawing.Point(125, 225);
            this.labelKms.Name = "labelKms";
            this.labelKms.Size = new System.Drawing.Size(30, 13);
            this.labelKms.TabIndex = 146;
            this.labelKms.Text = "Kms:";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(173, 173);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(218, 20);
            this.dateTimePickerInicio.TabIndex = 148;
            // 
            // dateTimePickerFim
            // 
            this.dateTimePickerFim.Location = new System.Drawing.Point(173, 199);
            this.dateTimePickerFim.Name = "dateTimePickerFim";
            this.dateTimePickerFim.Size = new System.Drawing.Size(218, 20);
            this.dateTimePickerFim.TabIndex = 149;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(173, 147);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(218, 20);
            this.textBoxValor.TabIndex = 150;
            // 
            // Adicionar_Aluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.dateTimePickerFim);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.textBoxKms);
            this.Controls.Add(this.labelKms);
            this.Controls.Add(this.labelDtaFim);
            this.Controls.Add(this.labelDtaInicio);
            this.Controls.Add(this.labelTipoServico);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonVoltar);
            this.Name = "Adicionar_Aluguer";
            this.Text = "Adicionar_Aluguer";
            this.Load += new System.EventHandler(this.Adicionar_Aluguer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDtaFim;
        private System.Windows.Forms.Label labelDtaInicio;
        private System.Windows.Forms.Label labelTipoServico;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.TextBox textBoxKms;
        private System.Windows.Forms.Label labelKms;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFim;
        private System.Windows.Forms.TextBox textBoxValor;
    }
}