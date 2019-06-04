namespace Real_Stand
{
    partial class Adicionar_Carro_Venda
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
            this.comboBoxCombustivel = new System.Windows.Forms.ComboBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.textBoxNumChassis = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelNumChassis = new System.Windows.Forms.Label();
            this.labelCombustivel = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.textBoxExtras = new System.Windows.Forms.TextBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxCombustivel
            // 
            this.comboBoxCombustivel.FormattingEnabled = true;
            this.comboBoxCombustivel.Items.AddRange(new object[] {
            "GASOLEO",
            "GASOLINA",
            "GPL"});
            this.comboBoxCombustivel.Location = new System.Drawing.Point(174, 161);
            this.comboBoxCombustivel.Name = "comboBoxCombustivel";
            this.comboBoxCombustivel.Size = new System.Drawing.Size(217, 21);
            this.comboBoxCombustivel.TabIndex = 153;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(316, 282);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 147;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(437, 418);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 146;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // textBoxNumChassis
            // 
            this.textBoxNumChassis.Location = new System.Drawing.Point(173, 186);
            this.textBoxNumChassis.Name = "textBoxNumChassis";
            this.textBoxNumChassis.Size = new System.Drawing.Size(218, 20);
            this.textBoxNumChassis.TabIndex = 144;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(173, 134);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(218, 20);
            this.textBoxModelo.TabIndex = 143;
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(114, 215);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(39, 13);
            this.labelMatricula.TabIndex = 142;
            this.labelMatricula.Text = "Extras:";
            // 
            // labelNumChassis
            // 
            this.labelNumChassis.AutoSize = true;
            this.labelNumChassis.Location = new System.Drawing.Point(93, 189);
            this.labelNumChassis.Name = "labelNumChassis";
            this.labelNumChassis.Size = new System.Drawing.Size(74, 13);
            this.labelNumChassis.TabIndex = 141;
            this.labelNumChassis.Text = "Num. Chassis:";
            // 
            // labelCombustivel
            // 
            this.labelCombustivel.AutoSize = true;
            this.labelCombustivel.Location = new System.Drawing.Point(100, 163);
            this.labelCombustivel.Name = "labelCombustivel";
            this.labelCombustivel.Size = new System.Drawing.Size(67, 13);
            this.labelCombustivel.TabIndex = 140;
            this.labelCombustivel.Text = "Combustivel:";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(122, 137);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(45, 13);
            this.labelModelo.TabIndex = 139;
            this.labelModelo.Text = "Modelo:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(127, 111);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 137;
            this.labelMarca.Text = "Marca:";
            // 
            // textBoxExtras
            // 
            this.textBoxExtras.Location = new System.Drawing.Point(173, 212);
            this.textBoxExtras.Multiline = true;
            this.textBoxExtras.Name = "textBoxExtras";
            this.textBoxExtras.Size = new System.Drawing.Size(218, 64);
            this.textBoxExtras.TabIndex = 156;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Items.AddRange(new object[] {
            "Alfa Romeo",
            "Audi",
            "BMW",
            "Chevrolet",
            "Citroën",
            "Dacia",
            "Fiat",
            "Ford",
            "Honda",
            "Hyundai",
            "Jeep",
            "Kia",
            "Lancia",
            "Land Rover",
            "Lexus",
            "Mazda",
            "Mercedes-Benz",
            "Mini",
            "Mitsubishi",
            "Nissan",
            "Opel",
            "Peugeot",
            "Renault",
            "Seat",
            "Skoda",
            "Smart",
            "Subaru",
            "Suzuki",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.comboBoxMarca.Location = new System.Drawing.Point(174, 107);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(217, 21);
            this.comboBoxMarca.TabIndex = 157;
            // 
            // Adicionar_Carro_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.textBoxExtras);
            this.Controls.Add(this.comboBoxCombustivel);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.textBoxNumChassis);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.labelMatricula);
            this.Controls.Add(this.labelNumChassis);
            this.Controls.Add(this.labelCombustivel);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelMarca);
            this.Name = "Adicionar_Carro_Venda";
            this.Text = "Adicionar_Carro_Venda";
            this.Load += new System.EventHandler(this.Adicionar_Carro_Venda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxCombustivel;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.TextBox textBoxNumChassis;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelNumChassis;
        private System.Windows.Forms.Label labelCombustivel;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox textBoxExtras;
        private System.Windows.Forms.ComboBox comboBoxMarca;
    }
}