namespace SacarDepositar_Polimorfismo
{
    partial class frmBanco
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
            this.rdbEspecial = new System.Windows.Forms.RadioButton();
            this.rdbPoupanca = new System.Windows.Forms.RadioButton();
            this.lblSaldoCE = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.lblSaldoCP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbEspecial
            // 
            this.rdbEspecial.AutoSize = true;
            this.rdbEspecial.Location = new System.Drawing.Point(22, 23);
            this.rdbEspecial.Name = "rdbEspecial";
            this.rdbEspecial.Size = new System.Drawing.Size(96, 17);
            this.rdbEspecial.TabIndex = 0;
            this.rdbEspecial.TabStop = true;
            this.rdbEspecial.Text = "Conta Especial";
            this.rdbEspecial.UseVisualStyleBackColor = true;
            // 
            // rdbPoupanca
            // 
            this.rdbPoupanca.AutoSize = true;
            this.rdbPoupanca.Location = new System.Drawing.Point(132, 23);
            this.rdbPoupanca.Name = "rdbPoupanca";
            this.rdbPoupanca.Size = new System.Drawing.Size(105, 17);
            this.rdbPoupanca.TabIndex = 1;
            this.rdbPoupanca.TabStop = true;
            this.rdbPoupanca.Text = "Conta Poupança";
            this.rdbPoupanca.UseVisualStyleBackColor = true;
            // 
            // lblSaldoCE
            // 
            this.lblSaldoCE.AutoSize = true;
            this.lblSaldoCE.Location = new System.Drawing.Point(31, 147);
            this.lblSaldoCE.Name = "lblSaldoCE";
            this.lblSaldoCE.Size = new System.Drawing.Size(54, 13);
            this.lblSaldoCE.TabIndex = 2;
            this.lblSaldoCE.Text = "Saldo CE:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(75, 65);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 3;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(36, 104);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(75, 23);
            this.btnDepositar.TabIndex = 4;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(144, 104);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 5;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // lblSaldoCP
            // 
            this.lblSaldoCP.AutoSize = true;
            this.lblSaldoCP.Location = new System.Drawing.Point(139, 147);
            this.lblSaldoCP.Name = "lblSaldoCP";
            this.lblSaldoCP.Size = new System.Drawing.Size(54, 13);
            this.lblSaldoCP.TabIndex = 6;
            this.lblSaldoCP.Text = "Saldo CP:";
            // 
            // frmBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 179);
            this.Controls.Add(this.lblSaldoCP);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblSaldoCE);
            this.Controls.Add(this.rdbPoupanca);
            this.Controls.Add(this.rdbEspecial);
            this.Name = "frmBanco";
            this.Text = "Banco Marlene S.A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbEspecial;
        private System.Windows.Forms.RadioButton rdbPoupanca;
        private System.Windows.Forms.Label lblSaldoCE;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label lblSaldoCP;
    }
}

