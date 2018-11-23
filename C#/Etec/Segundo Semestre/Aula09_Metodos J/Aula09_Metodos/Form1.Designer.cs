namespace Aula09_Metodos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.BtnMulti = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.btnPitagoras = new System.Windows.Forms.Button();
            this.btnBhaskara = new System.Windows.Forms.Button();
            this.BtnForçã = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.BtnForçã);
            this.groupBox1.Controls.Add(this.btnBhaskara);
            this.groupBox1.Controls.Add(this.btnPitagoras);
            this.groupBox1.Controls.Add(this.lblValor1);
            this.groupBox1.Controls.Add(this.lblValor2);
            this.groupBox1.Controls.Add(this.BtnLimpar);
            this.groupBox1.Controls.Add(this.BtnMulti);
            this.groupBox1.Controls.Add(this.btnSomar);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funções";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(335, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 38);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 38);
            this.textBox2.TabIndex = 1;
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(135, 161);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(125, 44);
            this.btnSomar.TabIndex = 2;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // BtnMulti
            // 
            this.BtnMulti.Location = new System.Drawing.Point(276, 161);
            this.BtnMulti.Name = "BtnMulti";
            this.BtnMulti.Size = new System.Drawing.Size(159, 44);
            this.BtnMulti.TabIndex = 3;
            this.BtnMulti.Text = "Multiplicar";
            this.BtnMulti.UseVisualStyleBackColor = true;
            this.BtnMulti.Click += new System.EventHandler(this.BtnMulti_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(460, 161);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(125, 44);
            this.BtnLimpar.TabIndex = 4;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(329, 33);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(106, 31);
            this.lblValor2.TabIndex = 5;
            this.lblValor2.Text = "Valor 2";
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(197, 33);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(106, 31);
            this.lblValor1.TabIndex = 6;
            this.lblValor1.Text = "Valor 1";
            // 
            // btnPitagoras
            // 
            this.btnPitagoras.Location = new System.Drawing.Point(525, 20);
            this.btnPitagoras.Name = "btnPitagoras";
            this.btnPitagoras.Size = new System.Drawing.Size(159, 44);
            this.btnPitagoras.TabIndex = 7;
            this.btnPitagoras.Text = "Pitagoras";
            this.btnPitagoras.UseVisualStyleBackColor = true;
            this.btnPitagoras.Click += new System.EventHandler(this.btnPitagoras_Click);
            // 
            // btnBhaskara
            // 
            this.btnBhaskara.Location = new System.Drawing.Point(525, 74);
            this.btnBhaskara.Name = "btnBhaskara";
            this.btnBhaskara.Size = new System.Drawing.Size(159, 44);
            this.btnBhaskara.TabIndex = 8;
            this.btnBhaskara.Text = "Bhaskara";
            this.btnBhaskara.UseVisualStyleBackColor = true;
            this.btnBhaskara.Click += new System.EventHandler(this.btnBhaskara_Click);
            // 
            // BtnForçã
            // 
            this.BtnForçã.Location = new System.Drawing.Point(6, 46);
            this.BtnForçã.Name = "BtnForçã";
            this.BtnForçã.Size = new System.Drawing.Size(159, 44);
            this.BtnForçã.TabIndex = 9;
            this.BtnForçã.Text = "Força";
            this.BtnForçã.UseVisualStyleBackColor = true;
            this.BtnForçã.Click += new System.EventHandler(this.BtnForçã_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(714, 247);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnMulti;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPitagoras;
        private System.Windows.Forms.Button btnBhaskara;
        private System.Windows.Forms.Button BtnForçã;
    }
}

