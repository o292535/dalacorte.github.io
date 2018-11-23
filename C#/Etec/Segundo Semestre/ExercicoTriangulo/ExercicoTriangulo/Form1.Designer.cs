namespace ExercicoTriangulo
{
    partial class Triangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Triangulo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::ExercicoTriangulo.Properties.Resources._1;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lblResposta);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.picImagem);
            this.groupBox1.Controls.Add(this.txtLado3);
            this.groupBox1.Controls.Add(this.txtLado2);
            this.groupBox1.Controls.Add(this.txtLado1);
            this.groupBox1.Controls.Add(this.lblLado3);
            this.groupBox1.Controls.Add(this.lblLado2);
            this.groupBox1.Controls.Add(this.lblLado1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Triangulo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.BackColor = System.Drawing.Color.Transparent;
            this.lblResposta.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.ForeColor = System.Drawing.Color.Brown;
            this.lblResposta.Location = new System.Drawing.Point(388, 317);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(109, 29);
            this.lblResposta.TabIndex = 9;
            this.lblResposta.Text = "Resultado";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.ForeColor = System.Drawing.Color.Brown;
            this.btnLimpar.Location = new System.Drawing.Point(9, 261);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(310, 43);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalcular.BackgroundImage")));
            this.btnCalcular.ForeColor = System.Drawing.Color.Brown;
            this.btnCalcular.Location = new System.Drawing.Point(10, 211);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(309, 44);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // picImagem
            // 
            this.picImagem.BackColor = System.Drawing.Color.Transparent;
            this.picImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picImagem.Location = new System.Drawing.Point(393, 53);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(280, 251);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 6;
            this.picImagem.TabStop = false;
            this.picImagem.Click += new System.EventHandler(this.picImagem_Click);
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(96, 167);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(223, 20);
            this.txtLado3.TabIndex = 5;
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(96, 114);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(223, 20);
            this.txtLado2.TabIndex = 4;
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(96, 53);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(223, 20);
            this.txtLado1.TabIndex = 3;
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.BackColor = System.Drawing.Color.Transparent;
            this.lblLado3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado3.ForeColor = System.Drawing.Color.Brown;
            this.lblLado3.Location = new System.Drawing.Point(6, 158);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(79, 29);
            this.lblLado3.TabIndex = 2;
            this.lblLado3.Text = "Lado 3";
            this.lblLado3.Click += new System.EventHandler(this.lblLado3_Click);
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.BackColor = System.Drawing.Color.Transparent;
            this.lblLado2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado2.ForeColor = System.Drawing.Color.Brown;
            this.lblLado2.Location = new System.Drawing.Point(6, 105);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(79, 29);
            this.lblLado2.TabIndex = 1;
            this.lblLado2.Text = "Lado 2";
            this.lblLado2.Click += new System.EventHandler(this.lblLado2_Click);
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.BackColor = System.Drawing.Color.Transparent;
            this.lblLado1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado1.ForeColor = System.Drawing.Color.Brown;
            this.lblLado1.Location = new System.Drawing.Point(6, 44);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(75, 29);
            this.lblLado1.TabIndex = 0;
            this.lblLado1.Text = "Lado 1";
            this.lblLado1.Click += new System.EventHandler(this.lblLado1_Click);
            // 
            // Triangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 381);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Triangulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Triangulo_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;

    }
}

