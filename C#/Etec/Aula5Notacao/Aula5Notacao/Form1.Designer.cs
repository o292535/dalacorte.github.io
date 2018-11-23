namespace Aula5Notacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.sair = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.Categoria = new System.Windows.Forms.Button();
            this.idade = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox
            // 
            this.grpBox.BackColor = System.Drawing.Color.Transparent;
            this.grpBox.BackgroundImage = global::Aula5Notacao.Properties.Resources.w;
            this.grpBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpBox.Controls.Add(this.txtResposta);
            this.grpBox.Controls.Add(this.pctBox);
            this.grpBox.Controls.Add(this.txtIdade);
            this.grpBox.Controls.Add(this.txtNome);
            this.grpBox.Controls.Add(this.sair);
            this.grpBox.Controls.Add(this.limpar);
            this.grpBox.Controls.Add(this.Categoria);
            this.grpBox.Controls.Add(this.idade);
            this.grpBox.Controls.Add(this.nome);
            this.grpBox.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox.Location = new System.Drawing.Point(0, 0);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(384, 361);
            this.grpBox.TabIndex = 0;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Idade";
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(12, 168);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(206, 37);
            this.txtResposta.TabIndex = 8;
            // 
            // pctBox
            // 
            this.pctBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBox.Location = new System.Drawing.Point(229, 110);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(143, 116);
            this.pctBox.TabIndex = 7;
            this.pctBox.TabStop = false;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(123, 110);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 37);
            this.txtIdade.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(123, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(249, 37);
            this.txtNome.TabIndex = 5;
            // 
            // sair
            // 
            this.sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sair.BackgroundImage")));
            this.sair.Location = new System.Drawing.Point(11, 320);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(366, 38);
            this.sair.TabIndex = 4;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // limpar
            // 
            this.limpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("limpar.BackgroundImage")));
            this.limpar.Location = new System.Drawing.Point(11, 276);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(366, 38);
            this.limpar.TabIndex = 3;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // Categoria
            // 
            this.Categoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Categoria.BackgroundImage")));
            this.Categoria.Location = new System.Drawing.Point(12, 232);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(366, 38);
            this.Categoria.TabIndex = 2;
            this.Categoria.Text = "Categoria";
            this.Categoria.UseVisualStyleBackColor = true;
            this.Categoria.Click += new System.EventHandler(this.Categoria_Click);
            // 
            // idade
            // 
            this.idade.AutoSize = true;
            this.idade.BackColor = System.Drawing.Color.Transparent;
            this.idade.Font = new System.Drawing.Font("Papyrus", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idade.Location = new System.Drawing.Point(6, 96);
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(110, 55);
            this.idade.TabIndex = 1;
            this.idade.Text = "Idade";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.BackColor = System.Drawing.Color.Transparent;
            this.nome.Font = new System.Drawing.Font("Papyrus", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(2, 33);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(115, 55);
            this.nome.TabIndex = 0;
            this.nome.Text = "Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.grpBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button Categoria;
        private System.Windows.Forms.Label idade;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.TextBox txtResposta;

    }
}

