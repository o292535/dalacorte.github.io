namespace Aula11_Quiz
{
    partial class frmQuestao5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestao5));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radCerto = new System.Windows.Forms.RadioButton();
            this.ss = new System.Windows.Forms.RadioButton();
            this.radErrado = new System.Windows.Forms.RadioButton();
            this.rasdsa = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radCerto);
            this.groupBox1.Controls.Add(this.ss);
            this.groupBox1.Controls.Add(this.radErrado);
            this.groupBox1.Controls.Add(this.rasdsa);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 246);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Questão 5";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(130, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radCerto
            // 
            this.radCerto.AutoSize = true;
            this.radCerto.Location = new System.Drawing.Point(293, 157);
            this.radCerto.Name = "radCerto";
            this.radCerto.Size = new System.Drawing.Size(135, 33);
            this.radCerto.TabIndex = 5;
            this.radCerto.TabStop = true;
            this.radCerto.Text = "Soul Evans";
            this.radCerto.UseVisualStyleBackColor = true;
            // 
            // ss
            // 
            this.ss.AutoSize = true;
            this.ss.Location = new System.Drawing.Point(6, 157);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(119, 33);
            this.ss.TabIndex = 4;
            this.ss.TabStop = true;
            this.ss.Text = "Kurapika";
            this.ss.UseVisualStyleBackColor = true;
            // 
            // radErrado
            // 
            this.radErrado.AutoSize = true;
            this.radErrado.Location = new System.Drawing.Point(293, 97);
            this.radErrado.Name = "radErrado";
            this.radErrado.Size = new System.Drawing.Size(90, 33);
            this.radErrado.TabIndex = 3;
            this.radErrado.TabStop = true;
            this.radErrado.Text = "Yasuo";
            this.radErrado.UseVisualStyleBackColor = true;
            // 
            // rasdsa
            // 
            this.rasdsa.AutoSize = true;
            this.rasdsa.Location = new System.Drawing.Point(6, 97);
            this.rasdsa.Name = "rasdsa";
            this.rasdsa.Size = new System.Drawing.Size(100, 33);
            this.rasdsa.TabIndex = 2;
            this.rasdsa.TabStop = true;
            this.rasdsa.Text = "Mikasa";
            this.rasdsa.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Location = new System.Drawing.Point(0, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(530, 55);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Adivinhe o nome do personagem que esta nesta foto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Aula11_Quiz.Properties.Resources.dd;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(519, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 221);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmQuestao5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 270);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuestao5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuestao5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radCerto;
        private System.Windows.Forms.RadioButton ss;
        private System.Windows.Forms.RadioButton radErrado;
        private System.Windows.Forms.RadioButton rasdsa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}