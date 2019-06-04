namespace Real_Stand
{
    partial class Adicionar_Carro_Oficina
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
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelCombustivel = new System.Windows.Forms.Label();
            this.labelNumChassis = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelKms = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxNumChassis = new System.Windows.Forms.TextBox();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.textBoxKms = new System.Windows.Forms.TextBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxMatricula2 = new System.Windows.Forms.TextBox();
            this.textBoxMatricula3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCombustivel = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.textBoxNif = new System.Windows.Forms.TextBox();
            this.labelNif = new System.Windows.Forms.Label();
            this.textBoxMostraNome = new System.Windows.Forms.TextBox();
            this.labelMostraNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(129, 123);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 0;
            this.labelMarca.Text = "Marca:";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(124, 149);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(45, 13);
            this.labelModelo.TabIndex = 2;
            this.labelModelo.Text = "Modelo:";
            // 
            // labelCombustivel
            // 
            this.labelCombustivel.AutoSize = true;
            this.labelCombustivel.Location = new System.Drawing.Point(102, 175);
            this.labelCombustivel.Name = "labelCombustivel";
            this.labelCombustivel.Size = new System.Drawing.Size(67, 13);
            this.labelCombustivel.TabIndex = 3;
            this.labelCombustivel.Text = "Combustivel:";
            // 
            // labelNumChassis
            // 
            this.labelNumChassis.AutoSize = true;
            this.labelNumChassis.Location = new System.Drawing.Point(95, 201);
            this.labelNumChassis.Name = "labelNumChassis";
            this.labelNumChassis.Size = new System.Drawing.Size(74, 13);
            this.labelNumChassis.TabIndex = 4;
            this.labelNumChassis.Text = "Num. Chassis:";
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(116, 227);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(53, 13);
            this.labelMatricula.TabIndex = 5;
            this.labelMatricula.Text = "Matricula:";
            // 
            // labelKms
            // 
            this.labelKms.AutoSize = true;
            this.labelKms.Location = new System.Drawing.Point(134, 253);
            this.labelKms.Name = "labelKms";
            this.labelKms.Size = new System.Drawing.Size(30, 13);
            this.labelKms.TabIndex = 6;
            this.labelKms.Text = "Kms:";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(175, 146);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(218, 20);
            this.textBoxModelo.TabIndex = 7;
            // 
            // textBoxNumChassis
            // 
            this.textBoxNumChassis.Location = new System.Drawing.Point(175, 198);
            this.textBoxNumChassis.Name = "textBoxNumChassis";
            this.textBoxNumChassis.Size = new System.Drawing.Size(218, 20);
            this.textBoxNumChassis.TabIndex = 9;
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(175, 224);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(35, 20);
            this.textBoxMatricula.TabIndex = 10;
            this.textBoxMatricula.TextChanged += new System.EventHandler(this.textBoxMatricula_TextChanged);
            this.textBoxMatricula.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxMatricula_KeyUp);
            // 
            // textBoxKms
            // 
            this.textBoxKms.Location = new System.Drawing.Point(175, 250);
            this.textBoxKms.Name = "textBoxKms";
            this.textBoxKms.Size = new System.Drawing.Size(218, 20);
            this.textBoxKms.TabIndex = 11;
            this.textBoxKms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKms_KeyPress);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(436, 415);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 108;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(317, 277);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 109;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxMatricula2
            // 
            this.textBoxMatricula2.Location = new System.Drawing.Point(239, 224);
            this.textBoxMatricula2.Name = "textBoxMatricula2";
            this.textBoxMatricula2.Size = new System.Drawing.Size(35, 20);
            this.textBoxMatricula2.TabIndex = 111;
            this.textBoxMatricula2.TextChanged += new System.EventHandler(this.textBoxMatricula2_TextChanged);
            this.textBoxMatricula2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxMatricula_KeyUp);
            // 
            // textBoxMatricula3
            // 
            this.textBoxMatricula3.Location = new System.Drawing.Point(302, 224);
            this.textBoxMatricula3.Name = "textBoxMatricula3";
            this.textBoxMatricula3.Size = new System.Drawing.Size(35, 20);
            this.textBoxMatricula3.TabIndex = 112;
            this.textBoxMatricula3.TextChanged += new System.EventHandler(this.textBoxMatricula3_TextChanged);
            this.textBoxMatricula3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxMatricula_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 114;
            this.label2.Text = "-";
            // 
            // comboBoxCombustivel
            // 
            this.comboBoxCombustivel.FormattingEnabled = true;
            this.comboBoxCombustivel.Items.AddRange(new object[] {
            "GASOLEO",
            "GASOLINA",
            "GPL"});
            this.comboBoxCombustivel.Location = new System.Drawing.Point(176, 173);
            this.comboBoxCombustivel.Name = "comboBoxCombustivel";
            this.comboBoxCombustivel.Size = new System.Drawing.Size(217, 21);
            this.comboBoxCombustivel.TabIndex = 115;
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
            this.comboBoxMarca.Location = new System.Drawing.Point(176, 120);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(217, 21);
            this.comboBoxMarca.TabIndex = 116;
            // 
            // textBoxNif
            // 
            this.textBoxNif.Location = new System.Drawing.Point(176, 67);
            this.textBoxNif.Name = "textBoxNif";
            this.textBoxNif.Size = new System.Drawing.Size(217, 20);
            this.textBoxNif.TabIndex = 120;
            // 
            // labelNif
            // 
            this.labelNif.AutoSize = true;
            this.labelNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNif.Location = new System.Drawing.Point(137, 67);
            this.labelNif.Name = "labelNif";
            this.labelNif.Size = new System.Drawing.Size(32, 20);
            this.labelNif.TabIndex = 119;
            this.labelNif.Text = "Nif:";
            // 
            // textBoxMostraNome
            // 
            this.textBoxMostraNome.Location = new System.Drawing.Point(176, 41);
            this.textBoxMostraNome.Name = "textBoxMostraNome";
            this.textBoxMostraNome.Size = new System.Drawing.Size(217, 20);
            this.textBoxMostraNome.TabIndex = 118;
            // 
            // labelMostraNome
            // 
            this.labelMostraNome.AutoSize = true;
            this.labelMostraNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostraNome.Location = new System.Drawing.Point(114, 39);
            this.labelMostraNome.Name = "labelMostraNome";
            this.labelMostraNome.Size = new System.Drawing.Size(55, 20);
            this.labelMostraNome.TabIndex = 117;
            this.labelMostraNome.Text = "Nome:";
            // 
            // Adicionar_Carro_Oficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.textBoxNif);
            this.Controls.Add(this.labelNif);
            this.Controls.Add(this.textBoxMostraNome);
            this.Controls.Add(this.labelMostraNome);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.comboBoxCombustivel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMatricula3);
            this.Controls.Add(this.textBoxMatricula2);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.textBoxKms);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.textBoxNumChassis);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.labelKms);
            this.Controls.Add(this.labelMatricula);
            this.Controls.Add(this.labelNumChassis);
            this.Controls.Add(this.labelCombustivel);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelMarca);
            this.Name = "Adicionar_Carro_Oficina";
            this.Text = "Adicionar_Carro_Oficina";
            this.Load += new System.EventHandler(this.Adicionar_Carro_Oficina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelCombustivel;
        private System.Windows.Forms.Label labelNumChassis;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelKms;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxNumChassis;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.TextBox textBoxKms;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxMatricula2;
        private System.Windows.Forms.TextBox textBoxMatricula3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCombustivel;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.TextBox textBoxNif;
        private System.Windows.Forms.Label labelNif;
        private System.Windows.Forms.TextBox textBoxMostraNome;
        private System.Windows.Forms.Label labelMostraNome;
    }
}