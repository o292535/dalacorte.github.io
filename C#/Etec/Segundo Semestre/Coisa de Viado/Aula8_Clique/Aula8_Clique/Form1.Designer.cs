namespace Aula8_Clique
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnClique = new System.Windows.Forms.Button();
            this.lstCliques = new System.Windows.Forms.ListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.chkAutomatico = new System.Windows.Forms.CheckBox();
            this.tmrClique = new System.Windows.Forms.Timer(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblFechar = new System.Windows.Forms.Label();
            this.tmrFechar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnClique
            // 
            this.btnClique.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClique.Location = new System.Drawing.Point(77, 66);
            this.btnClique.Name = "btnClique";
            this.btnClique.Size = new System.Drawing.Size(175, 55);
            this.btnClique.TabIndex = 1;
            this.btnClique.Text = "Clique";
            this.btnClique.UseVisualStyleBackColor = true;
            this.btnClique.Click += new System.EventHandler(this.btnClique_Click);
            // 
            // lstCliques
            // 
            this.lstCliques.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCliques.FormattingEnabled = true;
            this.lstCliques.ItemHeight = 39;
            this.lstCliques.Location = new System.Drawing.Point(295, 66);
            this.lstCliques.Name = "lstCliques";
            this.lstCliques.Size = new System.Drawing.Size(233, 277);
            this.lstCliques.TabIndex = 2;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(77, 151);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(175, 55);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // chkAutomatico
            // 
            this.chkAutomatico.AutoSize = true;
            this.chkAutomatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutomatico.Location = new System.Drawing.Point(68, 300);
            this.chkAutomatico.Name = "chkAutomatico";
            this.chkAutomatico.Size = new System.Drawing.Size(221, 43);
            this.chkAutomatico.TabIndex = 4;
            this.chkAutomatico.Text = "Automático";
            this.chkAutomatico.UseVisualStyleBackColor = true;
            this.chkAutomatico.CheckedChanged += new System.EventHandler(this.chkAutomatico_CheckedChanged);
            // 
            // tmrClique
            // 
            this.tmrClique.Interval = 1000;
            this.tmrClique.Tick += new System.EventHandler(this.tmrClique_Tick);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(77, 239);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(175, 55);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.Location = new System.Drawing.Point(12, 391);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(115, 39);
            this.lblFechar.TabIndex = 6;
            this.lblFechar.Text = "label1";
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
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(629, 448);
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.chkAutomatico);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lstCliques);
            this.Controls.Add(this.btnClique);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClique;
        private System.Windows.Forms.ListBox lstCliques;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.CheckBox chkAutomatico;
        private System.Windows.Forms.Timer tmrClique;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Timer tmrFechar;
    }
}

