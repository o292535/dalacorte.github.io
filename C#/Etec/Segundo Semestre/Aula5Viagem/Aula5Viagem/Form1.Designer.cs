namespace Aula5Viagem
{
    partial class frmViagem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkbox = new System.Windows.Forms.CheckBox();
            this.pctSexo2 = new System.Windows.Forms.PictureBox();
            this.lblIdade = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtSexo = new System.Windows.Forms.Label();
            this.btnF = new System.Windows.Forms.RadioButton();
            this.btnM = new System.Windows.Forms.RadioButton();
            this.pctSexo = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Limpar = new System.Windows.Forms.Button();
            this.pctViagem = new System.Windows.Forms.PictureBox();
            this.onibus = new System.Windows.Forms.CheckBox();
            this.navio = new System.Windows.Forms.CheckBox();
            this.aviao = new System.Windows.Forms.CheckBox();
            this.limpar2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSexo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctViagem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.limpar2);
            this.groupBox1.Controls.Add(this.chkbox);
            this.groupBox1.Controls.Add(this.pctSexo2);
            this.groupBox1.Controls.Add(this.lblIdade);
            this.groupBox1.Controls.Add(this.txtIdade);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.txtSexo);
            this.groupBox1.Controls.Add(this.btnF);
            this.groupBox1.Controls.Add(this.btnM);
            this.groupBox1.Controls.Add(this.pctSexo);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Made in Abyss - Viagens";
            // 
            // chkbox
            // 
            this.chkbox.AutoSize = true;
            this.chkbox.Location = new System.Drawing.Point(437, 43);
            this.chkbox.Name = "chkbox";
            this.chkbox.Size = new System.Drawing.Size(164, 35);
            this.chkbox.TabIndex = 10;
            this.chkbox.Text = "Concordo";
            this.chkbox.UseVisualStyleBackColor = true;
            this.chkbox.Visible = false;
            this.chkbox.CheckedChanged += new System.EventHandler(this.chkbox_CheckedChanged);
            // 
            // pctSexo2
            // 
            this.pctSexo2.Location = new System.Drawing.Point(321, 125);
            this.pctSexo2.Name = "pctSexo2";
            this.pctSexo2.Size = new System.Drawing.Size(280, 174);
            this.pctSexo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSexo2.TabIndex = 9;
            this.pctSexo2.TabStop = false;
            // 
            // lblIdade
            // 
            this.lblIdade.Location = new System.Drawing.Point(103, 346);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(137, 38);
            this.lblIdade.TabIndex = 2;
            // 
            // txtIdade
            // 
            this.txtIdade.AutoSize = true;
            this.txtIdade.Location = new System.Drawing.Point(6, 346);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(91, 31);
            this.txtIdade.TabIndex = 8;
            this.txtIdade.Text = "Idade";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(264, 346);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(337, 38);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtSexo
            // 
            this.txtSexo.AutoSize = true;
            this.txtSexo.Location = new System.Drawing.Point(6, 305);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(77, 31);
            this.txtSexo.TabIndex = 5;
            this.txtSexo.Text = "Sexo";
            // 
            // btnF
            // 
            this.btnF.AutoSize = true;
            this.btnF.Location = new System.Drawing.Point(439, 305);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(162, 35);
            this.btnF.TabIndex = 4;
            this.btnF.Text = "Feminino";
            this.btnF.UseVisualStyleBackColor = true;
            // 
            // btnM
            // 
            this.btnM.AutoSize = true;
            this.btnM.Location = new System.Drawing.Point(263, 305);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(170, 35);
            this.btnM.TabIndex = 3;
            this.btnM.Text = "Masculino";
            this.btnM.UseVisualStyleBackColor = true;
            // 
            // pctSexo
            // 
            this.pctSexo.Location = new System.Drawing.Point(12, 125);
            this.pctSexo.Name = "pctSexo";
            this.pctSexo.Size = new System.Drawing.Size(280, 174);
            this.pctSexo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSexo.TabIndex = 2;
            this.pctSexo.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(12, 81);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(589, 38);
            this.lblNome.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.BackColor = System.Drawing.Color.Transparent;
            this.txtNome.Location = new System.Drawing.Point(247, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(92, 31);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Nome";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(439, 305);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(162, 35);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.Text = "Feminino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(321, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(437, 43);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 35);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Concordo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.Limpar);
            this.groupBox2.Controls.Add(this.pctViagem);
            this.groupBox2.Controls.Add(this.onibus);
            this.groupBox2.Controls.Add(this.navio);
            this.groupBox2.Controls.Add(this.aviao);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(625, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 396);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Made in Abyss";
            this.groupBox2.Visible = false;
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(19, 194);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(280, 38);
            this.Limpar.TabIndex = 11;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.confirmar_Click);
            // 
            // pctViagem
            // 
            this.pctViagem.Location = new System.Drawing.Point(19, 238);
            this.pctViagem.Name = "pctViagem";
            this.pctViagem.Size = new System.Drawing.Size(280, 130);
            this.pctViagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctViagem.TabIndex = 11;
            this.pctViagem.TabStop = false;
            // 
            // onibus
            // 
            this.onibus.AutoSize = true;
            this.onibus.Location = new System.Drawing.Point(6, 138);
            this.onibus.Name = "onibus";
            this.onibus.Size = new System.Drawing.Size(130, 35);
            this.onibus.TabIndex = 13;
            this.onibus.Text = "Ônibus";
            this.onibus.UseVisualStyleBackColor = true;
            this.onibus.CheckedChanged += new System.EventHandler(this.onibus_CheckedChanged);
            // 
            // navio
            // 
            this.navio.AutoSize = true;
            this.navio.Location = new System.Drawing.Point(6, 83);
            this.navio.Name = "navio";
            this.navio.Size = new System.Drawing.Size(113, 35);
            this.navio.TabIndex = 12;
            this.navio.Text = "Navio";
            this.navio.UseVisualStyleBackColor = true;
            this.navio.CheckedChanged += new System.EventHandler(this.navio_CheckedChanged);
            // 
            // aviao
            // 
            this.aviao.AutoSize = true;
            this.aviao.Location = new System.Drawing.Point(6, 37);
            this.aviao.Name = "aviao";
            this.aviao.Size = new System.Drawing.Size(120, 35);
            this.aviao.TabIndex = 11;
            this.aviao.Text = "Avião ";
            this.aviao.UseVisualStyleBackColor = true;
            this.aviao.CheckedChanged += new System.EventHandler(this.aviao_CheckedChanged);
            // 
            // limpar2
            // 
            this.limpar2.Location = new System.Drawing.Point(12, 37);
            this.limpar2.Name = "limpar2";
            this.limpar2.Size = new System.Drawing.Size(150, 38);
            this.limpar2.TabIndex = 11;
            this.limpar2.Text = "Limpar";
            this.limpar2.UseVisualStyleBackColor = true;
            this.limpar2.Click += new System.EventHandler(this.limpar2_Click);
            // 
            // frmViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Aula5Viagem.Properties.Resources.W;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmViagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSexo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctViagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.PictureBox pctSexo;
        private System.Windows.Forms.TextBox lblNome;
        private System.Windows.Forms.RadioButton btnF;
        private System.Windows.Forms.RadioButton btnM;
        private System.Windows.Forms.Label txtSexo;
        private System.Windows.Forms.Label txtIdade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox lblIdade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctSexo2;
        private System.Windows.Forms.CheckBox chkbox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox onibus;
        private System.Windows.Forms.CheckBox navio;
        private System.Windows.Forms.CheckBox aviao;
        private System.Windows.Forms.PictureBox pctViagem;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button limpar2;
    }
}

