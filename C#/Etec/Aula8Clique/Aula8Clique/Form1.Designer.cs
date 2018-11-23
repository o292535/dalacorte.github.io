namespace Aula8Clique
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnClique;
            System.Windows.Forms.Button btnFechar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.chkAutomatico = new System.Windows.Forms.CheckBox();
            this.tmrClique = new System.Windows.Forms.Timer(this.components);
            this.lblFechar = new System.Windows.Forms.Label();
            this.tmrFechar = new System.Windows.Forms.Timer(this.components);
            btnClique = new System.Windows.Forms.Button();
            btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClique
            // 
            btnClique.BackgroundImage = global::Aula8Clique.Properties.Resources.bg;
            btnClique.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnClique.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnClique.ForeColor = System.Drawing.Color.LightSkyBlue;
            btnClique.Location = new System.Drawing.Point(335, 188);
            btnClique.Name = "btnClique";
            btnClique.Size = new System.Drawing.Size(165, 61);
            btnClique.TabIndex = 2;
            btnClique.Text = "Clique";
            btnClique.UseVisualStyleBackColor = true;
            btnClique.Click += new System.EventHandler(this.btnClique_Click);
            // 
            // btnFechar
            // 
            btnFechar.BackgroundImage = global::Aula8Clique.Properties.Resources.bg;
            btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnFechar.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnFechar.ForeColor = System.Drawing.Color.LightSkyBlue;
            btnFechar.Location = new System.Drawing.Point(335, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new System.Drawing.Size(165, 61);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(317, 304);
            this.listBox.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::Aula8Clique.Properties.Resources.bg;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpar.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnLimpar.Location = new System.Drawing.Point(335, 255);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(165, 61);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // chkAutomatico
            // 
            this.chkAutomatico.AutoSize = true;
            this.chkAutomatico.BackColor = System.Drawing.Color.Transparent;
            this.chkAutomatico.BackgroundImage = global::Aula8Clique.Properties.Resources.bg;
            this.chkAutomatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutomatico.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.chkAutomatico.Location = new System.Drawing.Point(335, 154);
            this.chkAutomatico.Name = "chkAutomatico";
            this.chkAutomatico.Size = new System.Drawing.Size(123, 28);
            this.chkAutomatico.TabIndex = 5;
            this.chkAutomatico.Text = "Automático";
            this.chkAutomatico.UseVisualStyleBackColor = false;
            this.chkAutomatico.CheckedChanged += new System.EventHandler(this.chkAutomatico_CheckedChanged);
            // 
            // tmrClique
            // 
            this.tmrClique.Interval = 500;
            this.tmrClique.Tick += new System.EventHandler(this.tmrClique_Tick);
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.BackColor = System.Drawing.Color.Transparent;
            this.lblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblFechar.Location = new System.Drawing.Point(336, 80);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(120, 13);
            this.lblFechar.TabIndex = 7;
            this.lblFechar.Text = "Another brick in the wall";
            this.lblFechar.Visible = false;
            // 
            // tmrFechar
            // 
            this.tmrFechar.Interval = 1000;
            this.tmrFechar.Tick += new System.EventHandler(this.tmrFechar_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aula8Clique.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 329);
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(btnFechar);
            this.Controls.Add(this.chkAutomatico);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.listBox);
            this.Controls.Add(btnClique);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.CheckBox chkAutomatico;
        private System.Windows.Forms.Timer tmrClique;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Timer tmrFechar;
    }
}

