namespace Aula3Controles
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
            this.btnCopiar = new System.Windows.Forms.Button();
            this.txtCopiar = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimparV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(134, 141);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(96, 40);
            this.btnCopiar.TabIndex = 1;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // txtCopiar
            // 
            this.txtCopiar.Location = new System.Drawing.Point(134, 87);
            this.txtCopiar.Name = "txtCopiar";
            this.txtCopiar.Size = new System.Drawing.Size(247, 20);
            this.txtCopiar.TabIndex = 0;
            this.txtCopiar.TextChanged += new System.EventHandler(this.txtCopiar_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Yellow;
            this.lblResultado.Location = new System.Drawing.Point(129, 201);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(165, 25);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Ensira o Texto";
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(134, 247);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(247, 20);
            this.txtResposta.TabIndex = 4;
            this.txtResposta.TextChanged += new System.EventHandler(this.txtResposta_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Testando Controles";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLimparV
            // 
            this.btnLimparV.Location = new System.Drawing.Point(267, 141);
            this.btnLimparV.Name = "btnLimparV";
            this.btnLimparV.Size = new System.Drawing.Size(96, 40);
            this.btnLimparV.TabIndex = 6;
            this.btnLimparV.Text = "Limpar";
            this.btnLimparV.UseVisualStyleBackColor = true;
            this.btnLimparV.Click += new System.EventHandler(this.btnLimparV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Aula3Controles.Properties.Resources._41340942;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(497, 296);
            this.Controls.Add(this.btnLimparV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtCopiar);
            this.Controls.Add(this.btnCopiar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testando Controles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.TextBox txtCopiar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimparV;
    }
}

