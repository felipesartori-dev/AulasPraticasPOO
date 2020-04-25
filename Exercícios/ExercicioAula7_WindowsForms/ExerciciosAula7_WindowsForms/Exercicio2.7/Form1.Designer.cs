namespace Exercicio2._7
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.radioBtnSenhorita = new System.Windows.Forms.RadioButton();
            this.radioBtnSenhora = new System.Windows.Forms.RadioButton();
            this.radioBtnSenhor = new System.Windows.Forms.RadioButton();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblExibeTexto = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.radioBtnSenhorita);
            this.panel1.Controls.Add(this.radioBtnSenhora);
            this.panel1.Controls.Add(this.radioBtnSenhor);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(53, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 226);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(3, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 17);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Pronome de Tratamento";
            // 
            // radioBtnSenhorita
            // 
            this.radioBtnSenhorita.AutoSize = true;
            this.radioBtnSenhorita.Location = new System.Drawing.Point(55, 145);
            this.radioBtnSenhorita.Name = "radioBtnSenhorita";
            this.radioBtnSenhorita.Size = new System.Drawing.Size(86, 21);
            this.radioBtnSenhorita.TabIndex = 2;
            this.radioBtnSenhorita.Text = "Senhorita";
            this.radioBtnSenhorita.UseVisualStyleBackColor = true;
            // 
            // radioBtnSenhora
            // 
            this.radioBtnSenhora.AutoSize = true;
            this.radioBtnSenhora.Location = new System.Drawing.Point(55, 108);
            this.radioBtnSenhora.Name = "radioBtnSenhora";
            this.radioBtnSenhora.Size = new System.Drawing.Size(78, 21);
            this.radioBtnSenhora.TabIndex = 1;
            this.radioBtnSenhora.Text = "Senhora";
            this.radioBtnSenhora.UseVisualStyleBackColor = true;
            // 
            // radioBtnSenhor
            // 
            this.radioBtnSenhor.AutoSize = true;
            this.radioBtnSenhor.Location = new System.Drawing.Point(55, 68);
            this.radioBtnSenhor.Name = "radioBtnSenhor";
            this.radioBtnSenhor.Size = new System.Drawing.Size(69, 21);
            this.radioBtnSenhor.TabIndex = 0;
            this.radioBtnSenhor.Text = "Senhor";
            this.radioBtnSenhor.UseVisualStyleBackColor = true;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(50, 288);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(58, 17);
            this.lblPeriodo.TabIndex = 1;
            this.lblPeriodo.Text = "Periodo";
            // 
            // lblExibeTexto
            // 
            this.lblExibeTexto.AutoSize = true;
            this.lblExibeTexto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExibeTexto.Location = new System.Drawing.Point(91, 400);
            this.lblExibeTexto.Name = "lblExibeTexto";
            this.lblExibeTexto.Size = new System.Drawing.Size(47, 17);
            this.lblExibeTexto.TabIndex = 2;
            this.lblExibeTexto.Text = "label3";
            this.lblExibeTexto.Visible = false;
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Items.AddRange(new object[] {
            "Manhã",
            "Tarde",
            "Noite"});
            this.cboPeriodo.Location = new System.Drawing.Point(109, 285);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(144, 25);
            this.cboPeriodo.TabIndex = 3;
            this.cboPeriodo.Text = "Selecione";
            // 
            // btnConfirma
            // 
            this.btnConfirma.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.Location = new System.Drawing.Point(53, 335);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(85, 31);
            this.btnConfirma.TabIndex = 4;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancela.Location = new System.Drawing.Point(168, 335);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(85, 31);
            this.btnCancela.TabIndex = 6;
            this.btnCancela.Text = "Cancela";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 450);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.cboPeriodo);
            this.Controls.Add(this.lblExibeTexto);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Saudação";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton radioBtnSenhorita;
        private System.Windows.Forms.RadioButton radioBtnSenhora;
        private System.Windows.Forms.RadioButton radioBtnSenhor;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblExibeTexto;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnCancela;
    }
}

