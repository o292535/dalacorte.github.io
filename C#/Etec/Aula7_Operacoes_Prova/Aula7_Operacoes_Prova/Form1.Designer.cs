namespace Aula7_Operacoes_Prova
{
    partial class Form1
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
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDivisao = new System.Windows.Forms.RadioButton();
            this.radMultiplicacao = new System.Windows.Forms.RadioButton();
            this.radSubtracao = new System.Windows.Forms.RadioButton();
            this.radAdicao = new System.Windows.Forms.RadioButton();
            this.pctOperacao = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctOperacao)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1.Location = new System.Drawing.Point(197, 29);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(148, 38);
            this.txtValor1.TabIndex = 0;
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2.Location = new System.Drawing.Point(197, 86);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(148, 38);
            this.txtValor2.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(197, 136);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(123, 36);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(197, 180);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(123, 36);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(197, 228);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(123, 36);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o 1º número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Digite o 2º número";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDivisao);
            this.groupBox1.Controls.Add(this.radMultiplicacao);
            this.groupBox1.Controls.Add(this.radSubtracao);
            this.groupBox1.Controls.Add(this.radAdicao);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(351, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 235);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            // 
            // radDivisao
            // 
            this.radDivisao.AutoSize = true;
            this.radDivisao.Location = new System.Drawing.Point(26, 196);
            this.radDivisao.Name = "radDivisao";
            this.radDivisao.Size = new System.Drawing.Size(104, 35);
            this.radDivisao.TabIndex = 3;
            this.radDivisao.TabStop = true;
            this.radDivisao.Text = "Divisão";
            this.radDivisao.UseVisualStyleBackColor = true;
            // 
            // radMultiplicacao
            // 
            this.radMultiplicacao.AutoSize = true;
            this.radMultiplicacao.Location = new System.Drawing.Point(26, 146);
            this.radMultiplicacao.Name = "radMultiplicacao";
            this.radMultiplicacao.Size = new System.Drawing.Size(158, 35);
            this.radMultiplicacao.TabIndex = 2;
            this.radMultiplicacao.TabStop = true;
            this.radMultiplicacao.Text = "Multiplicação";
            this.radMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // radSubtracao
            // 
            this.radSubtracao.AutoSize = true;
            this.radSubtracao.Location = new System.Drawing.Point(26, 95);
            this.radSubtracao.Name = "radSubtracao";
            this.radSubtracao.Size = new System.Drawing.Size(131, 35);
            this.radSubtracao.TabIndex = 1;
            this.radSubtracao.TabStop = true;
            this.radSubtracao.Text = "Subtração";
            this.radSubtracao.UseVisualStyleBackColor = true;
            // 
            // radAdicao
            // 
            this.radAdicao.AutoSize = true;
            this.radAdicao.Location = new System.Drawing.Point(26, 38);
            this.radAdicao.Name = "radAdicao";
            this.radAdicao.Size = new System.Drawing.Size(99, 35);
            this.radAdicao.TabIndex = 0;
            this.radAdicao.TabStop = true;
            this.radAdicao.Text = "Adição";
            this.radAdicao.UseVisualStyleBackColor = true;
            // 
            // pctOperacao
            // 
            this.pctOperacao.Location = new System.Drawing.Point(4, 136);
            this.pctOperacao.Name = "pctOperacao";
            this.pctOperacao.Size = new System.Drawing.Size(187, 128);
            this.pctOperacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctOperacao.TabIndex = 8;
            this.pctOperacao.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(642, 287);
            this.Controls.Add(this.pctOperacao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctOperacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDivisao;
        private System.Windows.Forms.RadioButton radMultiplicacao;
        private System.Windows.Forms.RadioButton radSubtracao;
        private System.Windows.Forms.RadioButton radAdicao;
        private System.Windows.Forms.PictureBox pctOperacao;
    }
}

