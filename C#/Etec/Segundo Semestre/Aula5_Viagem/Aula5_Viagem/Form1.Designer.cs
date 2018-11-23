namespace Aula5_Viagem
{
    partial class FrmViagem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTermos = new System.Windows.Forms.CheckBox();
            this.pctfoto = new System.Windows.Forms.PictureBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.radFeminino = new System.Windows.Forms.RadioButton();
            this.gpbTransporte = new System.Windows.Forms.GroupBox();
            this.pctVeiculo = new System.Windows.Forms.PictureBox();
            this.radAereo = new System.Windows.Forms.RadioButton();
            this.radTerrestre = new System.Windows.Forms.RadioButton();
            this.radAquatico = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctfoto)).BeginInit();
            this.gpbTransporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.chkTermos);
            this.groupBox1.Controls.Add(this.pctfoto);
            this.groupBox1.Controls.Add(this.txtIdade);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.radMasculino);
            this.groupBox1.Controls.Add(this.radFeminino);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 362);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boa Viagem";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkTermos
            // 
            this.chkTermos.AutoSize = true;
            this.chkTermos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTermos.Location = new System.Drawing.Point(14, 295);
            this.chkTermos.Name = "chkTermos";
            this.chkTermos.Size = new System.Drawing.Size(540, 28);
            this.chkTermos.TabIndex = 7;
            this.chkTermos.Text = "Concordo com os termos de uso de menores de idade";
            this.chkTermos.UseVisualStyleBackColor = true;
            this.chkTermos.Visible = false;
            this.chkTermos.CheckedChanged += new System.EventHandler(this.chkTermos_CheckedChanged);
            // 
            // pctfoto
            // 
            this.pctfoto.BackColor = System.Drawing.Color.Transparent;
            this.pctfoto.Location = new System.Drawing.Point(298, 99);
            this.pctfoto.Name = "pctfoto";
            this.pctfoto.Size = new System.Drawing.Size(226, 175);
            this.pctfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctfoto.TabIndex = 1;
            this.pctfoto.TabStop = false;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(108, 198);
            this.txtIdade.Multiline = true;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(47, 34);
            this.txtIdade.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Location = new System.Drawing.Point(8, 55);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(99, 31);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(170, 235);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(122, 39);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Idade:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(113, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(411, 38);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Location = new System.Drawing.Point(6, 115);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(163, 35);
            this.radMasculino.TabIndex = 1;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = true;
            // 
            // radFeminino
            // 
            this.radFeminino.AutoSize = true;
            this.radFeminino.Location = new System.Drawing.Point(6, 156);
            this.radFeminino.Name = "radFeminino";
            this.radFeminino.Size = new System.Drawing.Size(151, 35);
            this.radFeminino.TabIndex = 2;
            this.radFeminino.Text = "Feminino";
            this.radFeminino.UseVisualStyleBackColor = true;
            // 
            // gpbTransporte
            // 
            this.gpbTransporte.BackColor = System.Drawing.Color.Transparent;
            this.gpbTransporte.Controls.Add(this.pctVeiculo);
            this.gpbTransporte.Controls.Add(this.radAereo);
            this.gpbTransporte.Controls.Add(this.radTerrestre);
            this.gpbTransporte.Controls.Add(this.radAquatico);
            this.gpbTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTransporte.Location = new System.Drawing.Point(578, 12);
            this.gpbTransporte.Name = "gpbTransporte";
            this.gpbTransporte.Size = new System.Drawing.Size(330, 350);
            this.gpbTransporte.TabIndex = 2;
            this.gpbTransporte.TabStop = false;
            this.gpbTransporte.Text = "Meio de Transporte";
            this.gpbTransporte.Visible = false;
            this.gpbTransporte.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // pctVeiculo
            // 
            this.pctVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.pctVeiculo.Location = new System.Drawing.Point(6, 209);
            this.pctVeiculo.Name = "pctVeiculo";
            this.pctVeiculo.Size = new System.Drawing.Size(318, 135);
            this.pctVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctVeiculo.TabIndex = 8;
            this.pctVeiculo.TabStop = false;
            // 
            // radAereo
            // 
            this.radAereo.AutoSize = true;
            this.radAereo.Location = new System.Drawing.Point(18, 151);
            this.radAereo.Name = "radAereo";
            this.radAereo.Size = new System.Drawing.Size(104, 35);
            this.radAereo.TabIndex = 2;
            this.radAereo.Text = "Aéreo";
            this.radAereo.UseVisualStyleBackColor = true;
            this.radAereo.CheckedChanged += new System.EventHandler(this.radAereo_CheckedChanged_1);
            // 
            // radTerrestre
            // 
            this.radTerrestre.AutoSize = true;
            this.radTerrestre.Location = new System.Drawing.Point(18, 106);
            this.radTerrestre.Name = "radTerrestre";
            this.radTerrestre.Size = new System.Drawing.Size(143, 35);
            this.radTerrestre.TabIndex = 1;
            this.radTerrestre.Text = "Terrestre";
            this.radTerrestre.UseVisualStyleBackColor = true;
            this.radTerrestre.CheckedChanged += new System.EventHandler(this.radTerrestre_CheckedChanged_1);
            // 
            // radAquatico
            // 
            this.radAquatico.AutoSize = true;
            this.radAquatico.Location = new System.Drawing.Point(18, 65);
            this.radAquatico.Name = "radAquatico";
            this.radAquatico.Size = new System.Drawing.Size(138, 35);
            this.radAquatico.TabIndex = 0;
            this.radAquatico.Text = "Aquatico";
            this.radAquatico.UseVisualStyleBackColor = true;
            this.radAquatico.CheckedChanged += new System.EventHandler(this.radAquatico_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(431, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Aula5_Viagem.Properties.Resources.aa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 370);
            this.Controls.Add(this.gpbTransporte);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "FrmViagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viagem";
            this.Load += new System.EventHandler(this.FrmViagem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctfoto)).EndInit();
            this.gpbTransporte.ResumeLayout(false);
            this.gpbTransporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctfoto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.RadioButton radFeminino;
        private System.Windows.Forms.CheckBox chkTermos;
        private System.Windows.Forms.GroupBox gpbTransporte;
        private System.Windows.Forms.RadioButton radAereo;
        private System.Windows.Forms.RadioButton radTerrestre;
        private System.Windows.Forms.RadioButton radAquatico;
        private System.Windows.Forms.PictureBox pctVeiculo;
        private System.Windows.Forms.Button button1;
    }
}

