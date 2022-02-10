namespace ConversaodeTemperatura
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.rbCelsius1 = new System.Windows.Forms.RadioButton();
            this.rbKelvin1 = new System.Windows.Forms.RadioButton();
            this.rbFahrenheit1 = new System.Windows.Forms.RadioButton();
            this.gbEntrada = new System.Windows.Forms.GroupBox();
            this.rbKelvin2 = new System.Windows.Forms.RadioButton();
            this.rbCelsius2 = new System.Windows.Forms.RadioButton();
            this.rbFahrenheit2 = new System.Windows.Forms.RadioButton();
            this.gbSaida = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btConverte = new System.Windows.Forms.Button();
            this.gbEntrada.SuspendLayout();
            this.gbSaida.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(224, 27);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 26);
            this.txtValor.TabIndex = 0;
            // 
            // rbCelsius1
            // 
            this.rbCelsius1.AutoSize = true;
            this.rbCelsius1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCelsius1.Location = new System.Drawing.Point(74, 16);
            this.rbCelsius1.Name = "rbCelsius1";
            this.rbCelsius1.Size = new System.Drawing.Size(78, 22);
            this.rbCelsius1.TabIndex = 2;
            this.rbCelsius1.TabStop = true;
            this.rbCelsius1.Text = "Celsius";
            this.rbCelsius1.UseVisualStyleBackColor = true;
            this.rbCelsius1.CheckedChanged += new System.EventHandler(this.rbCelsius2_CheckedChanged);
            // 
            // rbKelvin1
            // 
            this.rbKelvin1.AutoSize = true;
            this.rbKelvin1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKelvin1.Location = new System.Drawing.Point(74, 44);
            this.rbKelvin1.Name = "rbKelvin1";
            this.rbKelvin1.Size = new System.Drawing.Size(68, 22);
            this.rbKelvin1.TabIndex = 2;
            this.rbKelvin1.TabStop = true;
            this.rbKelvin1.Text = "Kelvin";
            this.rbKelvin1.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheit1
            // 
            this.rbFahrenheit1.AutoSize = true;
            this.rbFahrenheit1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFahrenheit1.Location = new System.Drawing.Point(71, 72);
            this.rbFahrenheit1.Name = "rbFahrenheit1";
            this.rbFahrenheit1.Size = new System.Drawing.Size(100, 22);
            this.rbFahrenheit1.TabIndex = 2;
            this.rbFahrenheit1.TabStop = true;
            this.rbFahrenheit1.Text = "Fahrenheit";
            this.rbFahrenheit1.UseVisualStyleBackColor = true;
            this.rbFahrenheit1.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // gbEntrada
            // 
            this.gbEntrada.Controls.Add(this.rbFahrenheit1);
            this.gbEntrada.Controls.Add(this.rbKelvin1);
            this.gbEntrada.Controls.Add(this.rbCelsius1);
            this.gbEntrada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEntrada.Location = new System.Drawing.Point(43, 60);
            this.gbEntrada.Name = "gbEntrada";
            this.gbEntrada.Size = new System.Drawing.Size(200, 100);
            this.gbEntrada.TabIndex = 1;
            this.gbEntrada.TabStop = false;
            this.gbEntrada.Text = "Entrada";
            // 
            // rbKelvin2
            // 
            this.rbKelvin2.AutoSize = true;
            this.rbKelvin2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKelvin2.Location = new System.Drawing.Point(78, 44);
            this.rbKelvin2.Name = "rbKelvin2";
            this.rbKelvin2.Size = new System.Drawing.Size(68, 22);
            this.rbKelvin2.TabIndex = 2;
            this.rbKelvin2.TabStop = true;
            this.rbKelvin2.Text = "Kelvin";
            this.rbKelvin2.UseVisualStyleBackColor = true;
            // 
            // rbCelsius2
            // 
            this.rbCelsius2.AutoSize = true;
            this.rbCelsius2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCelsius2.Location = new System.Drawing.Point(78, 16);
            this.rbCelsius2.Name = "rbCelsius2";
            this.rbCelsius2.Size = new System.Drawing.Size(78, 22);
            this.rbCelsius2.TabIndex = 2;
            this.rbCelsius2.TabStop = true;
            this.rbCelsius2.Text = "Celsius";
            this.rbCelsius2.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheit2
            // 
            this.rbFahrenheit2.AutoSize = true;
            this.rbFahrenheit2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFahrenheit2.Location = new System.Drawing.Point(78, 72);
            this.rbFahrenheit2.Name = "rbFahrenheit2";
            this.rbFahrenheit2.Size = new System.Drawing.Size(100, 22);
            this.rbFahrenheit2.TabIndex = 2;
            this.rbFahrenheit2.TabStop = true;
            this.rbFahrenheit2.Text = "Fahrenheit";
            this.rbFahrenheit2.UseVisualStyleBackColor = true;
            this.rbFahrenheit2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // gbSaida
            // 
            this.gbSaida.Controls.Add(this.rbFahrenheit2);
            this.gbSaida.Controls.Add(this.rbCelsius2);
            this.gbSaida.Controls.Add(this.rbKelvin2);
            this.gbSaida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSaida.Location = new System.Drawing.Point(336, 60);
            this.gbSaida.Name = "gbSaida";
            this.gbSaida.Size = new System.Drawing.Size(200, 100);
            this.gbSaida.TabIndex = 2;
            this.gbSaida.TabStop = false;
            this.gbSaida.Text = "Saída";
            this.gbSaida.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(136, 248);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 18);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(224, 246);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 4;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::ConversaodeTemperatura.Properties.Resources.download1;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.Location = new System.Drawing.Point(399, 277);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 85);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btConverte
            // 
            this.btConverte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConverte.Image = global::ConversaodeTemperatura.Properties.Resources.convertimag1;
            this.btConverte.Location = new System.Drawing.Point(120, 286);
            this.btConverte.Name = "btConverte";
            this.btConverte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btConverte.Size = new System.Drawing.Size(123, 76);
            this.btConverte.TabIndex = 3;
            this.btConverte.Text = "Ok";
            this.btConverte.UseVisualStyleBackColor = true;
            this.btConverte.Click += new System.EventHandler(this.btConverte_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 374);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btConverte);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbEntrada);
            this.Controls.Add(this.gbSaida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Temperatura";
            this.gbEntrada.ResumeLayout(false);
            this.gbEntrada.PerformLayout();
            this.gbSaida.ResumeLayout(false);
            this.gbSaida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.RadioButton rbCelsius1;
        private System.Windows.Forms.RadioButton rbKelvin1;
        private System.Windows.Forms.RadioButton rbFahrenheit1;
        private System.Windows.Forms.GroupBox gbEntrada;
        private System.Windows.Forms.Button btConverte;
        private System.Windows.Forms.RadioButton rbKelvin2;
        private System.Windows.Forms.RadioButton rbCelsius2;
        private System.Windows.Forms.RadioButton rbFahrenheit2;
        private System.Windows.Forms.GroupBox gbSaida;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnLimpar;
    }
}

