namespace Aula07_Calculadora
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprimeironumero = new System.Windows.Forms.TextBox();
            this.txtsegundonumero = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radAdicao = new System.Windows.Forms.RadioButton();
            this.radSubtracao = new System.Windows.Forms.RadioButton();
            this.radMultiplicacao = new System.Windows.Forms.RadioButton();
            this.radDivisao = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o 1º Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o 2º Número:";
            // 
            // txtprimeironumero
            // 
            this.txtprimeironumero.Location = new System.Drawing.Point(135, 32);
            this.txtprimeironumero.Name = "txtprimeironumero";
            this.txtprimeironumero.Size = new System.Drawing.Size(100, 20);
            this.txtprimeironumero.TabIndex = 2;
            // 
            // txtsegundonumero
            // 
            this.txtsegundonumero.Location = new System.Drawing.Point(135, 71);
            this.txtsegundonumero.Name = "txtsegundonumero";
            this.txtsegundonumero.Size = new System.Drawing.Size(100, 20);
            this.txtsegundonumero.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(43, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(145, 95);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(145, 124);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(145, 153);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDivisao);
            this.groupBox1.Controls.Add(this.radMultiplicacao);
            this.groupBox1.Controls.Add(this.radSubtracao);
            this.groupBox1.Controls.Add(this.radAdicao);
            this.groupBox1.Location = new System.Drawing.Point(261, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 145);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operadores";
            // 
            // radAdicao
            // 
            this.radAdicao.AutoSize = true;
            this.radAdicao.Location = new System.Drawing.Point(22, 28);
            this.radAdicao.Name = "radAdicao";
            this.radAdicao.Size = new System.Drawing.Size(58, 17);
            this.radAdicao.TabIndex = 0;
            this.radAdicao.TabStop = true;
            this.radAdicao.Text = "Adição";
            this.radAdicao.UseVisualStyleBackColor = true;
            this.radAdicao.CheckedChanged += new System.EventHandler(this.radAdicao_CheckedChanged);
            // 
            // radSubtracao
            // 
            this.radSubtracao.AutoSize = true;
            this.radSubtracao.Location = new System.Drawing.Point(22, 55);
            this.radSubtracao.Name = "radSubtracao";
            this.radSubtracao.Size = new System.Drawing.Size(74, 17);
            this.radSubtracao.TabIndex = 1;
            this.radSubtracao.TabStop = true;
            this.radSubtracao.Text = "Subtração";
            this.radSubtracao.UseVisualStyleBackColor = true;
            this.radSubtracao.CheckedChanged += new System.EventHandler(this.radSubtracao_CheckedChanged);
            // 
            // radMultiplicacao
            // 
            this.radMultiplicacao.AutoSize = true;
            this.radMultiplicacao.Location = new System.Drawing.Point(22, 81);
            this.radMultiplicacao.Name = "radMultiplicacao";
            this.radMultiplicacao.Size = new System.Drawing.Size(87, 17);
            this.radMultiplicacao.TabIndex = 2;
            this.radMultiplicacao.TabStop = true;
            this.radMultiplicacao.Text = "Multiplicação";
            this.radMultiplicacao.UseVisualStyleBackColor = true;
            this.radMultiplicacao.CheckedChanged += new System.EventHandler(this.radMultiplicacao_CheckedChanged);
            // 
            // radDivisao
            // 
            this.radDivisao.AutoSize = true;
            this.radDivisao.Location = new System.Drawing.Point(22, 110);
            this.radDivisao.Name = "radDivisao";
            this.radDivisao.Size = new System.Drawing.Size(60, 17);
            this.radDivisao.TabIndex = 3;
            this.radDivisao.TabStop = true;
            this.radDivisao.Text = "Divisão";
            this.radDivisao.UseVisualStyleBackColor = true;
            this.radDivisao.CheckedChanged += new System.EventHandler(this.radDivisao_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(442, 203);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtsegundonumero);
            this.Controls.Add(this.txtprimeironumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Operadores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprimeironumero;
        private System.Windows.Forms.TextBox txtsegundonumero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDivisao;
        private System.Windows.Forms.RadioButton radMultiplicacao;
        private System.Windows.Forms.RadioButton radSubtracao;
        private System.Windows.Forms.RadioButton radAdicao;
    }
}

