namespace Aula8Loop
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.pbFor = new System.Windows.Forms.ProgressBar();
            this.pbWhile = new System.Windows.Forms.ProgressBar();
            this.pbDoWhile = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Brown;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 279);
            this.listBox1.TabIndex = 0;
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.Color.Transparent;
            this.btnFor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFor.BackgroundImage")));
            this.btnFor.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFor.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnFor.Location = new System.Drawing.Point(12, 303);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(120, 38);
            this.btnFor.TabIndex = 1;
            this.btnFor.Text = "for";
            this.btnFor.UseVisualStyleBackColor = false;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.Brown;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(159, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 279);
            this.listBox2.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.ForeColor = System.Drawing.Color.Brown;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 25;
            this.listBox3.Location = new System.Drawing.Point(304, 12);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 279);
            this.listBox3.TabIndex = 3;
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.Color.Transparent;
            this.btnWhile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWhile.BackgroundImage")));
            this.btnWhile.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhile.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnWhile.Location = new System.Drawing.Point(159, 303);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(120, 38);
            this.btnWhile.TabIndex = 4;
            this.btnWhile.Text = "while";
            this.btnWhile.UseVisualStyleBackColor = false;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.BackColor = System.Drawing.Color.Transparent;
            this.btnDoWhile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoWhile.BackgroundImage")));
            this.btnDoWhile.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoWhile.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDoWhile.Location = new System.Drawing.Point(304, 303);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(120, 38);
            this.btnDoWhile.TabIndex = 5;
            this.btnDoWhile.Text = "do...while";
            this.btnDoWhile.UseVisualStyleBackColor = false;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.Brown;
            this.lblText.Location = new System.Drawing.Point(430, 12);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(60, 25);
            this.lblText.TabIndex = 7;
            this.lblText.Text = "Loops";
            // 
            // pbFor
            // 
            this.pbFor.Location = new System.Drawing.Point(12, 347);
            this.pbFor.Maximum = 10;
            this.pbFor.Name = "pbFor";
            this.pbFor.Size = new System.Drawing.Size(120, 23);
            this.pbFor.TabIndex = 8;
            // 
            // pbWhile
            // 
            this.pbWhile.Location = new System.Drawing.Point(159, 347);
            this.pbWhile.Name = "pbWhile";
            this.pbWhile.Size = new System.Drawing.Size(120, 23);
            this.pbWhile.TabIndex = 9;
            // 
            // pbDoWhile
            // 
            this.pbDoWhile.Location = new System.Drawing.Point(304, 347);
            this.pbDoWhile.Maximum = 1000;
            this.pbDoWhile.Name = "pbDoWhile";
            this.pbDoWhile.Size = new System.Drawing.Size(120, 23);
            this.pbDoWhile.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aula8Loop.Properties.Resources.No_Game_No_Life_em_breve_na_RTP_2_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 373);
            this.Controls.Add(this.pbDoWhile);
            this.Controls.Add(this.pbWhile);
            this.Controls.Add(this.pbFor);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.ProgressBar pbFor;
        private System.Windows.Forms.ProgressBar pbWhile;
        private System.Windows.Forms.ProgressBar pbDoWhile;
    }
}

