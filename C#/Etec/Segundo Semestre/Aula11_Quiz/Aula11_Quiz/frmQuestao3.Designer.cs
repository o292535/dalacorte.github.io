namespace Aula11_Quiz
{
    partial class frmQuestao3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestao3));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radErrado3 = new System.Windows.Forms.RadioButton();
            this.radErrado2 = new System.Windows.Forms.RadioButton();
            this.radCerto = new System.Windows.Forms.RadioButton();
            this.radErrado = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radErrado3);
            this.groupBox1.Controls.Add(this.radErrado2);
            this.groupBox1.Controls.Add(this.radCerto);
            this.groupBox1.Controls.Add(this.radErrado);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Questão 3";
            // 
            // radErrado3
            // 
            this.radErrado3.AutoSize = true;
            this.radErrado3.Location = new System.Drawing.Point(293, 157);
            this.radErrado3.Name = "radErrado3";
            this.radErrado3.Size = new System.Drawing.Size(86, 33);
            this.radErrado3.TabIndex = 5;
            this.radErrado3.TabStop = true;
            this.radErrado3.Text = "Sonic";
            this.radErrado3.UseVisualStyleBackColor = true;
            // 
            // radErrado2
            // 
            this.radErrado2.AutoSize = true;
            this.radErrado2.Location = new System.Drawing.Point(6, 157);
            this.radErrado2.Name = "radErrado2";
            this.radErrado2.Size = new System.Drawing.Size(97, 33);
            this.radErrado2.TabIndex = 4;
            this.radErrado2.TabStop = true;
            this.radErrado2.Text = "Naruto";
            this.radErrado2.UseVisualStyleBackColor = true;
            // 
            // radCerto
            // 
            this.radCerto.AutoSize = true;
            this.radCerto.Location = new System.Drawing.Point(293, 97);
            this.radCerto.Name = "radCerto";
            this.radCerto.Size = new System.Drawing.Size(101, 33);
            this.radCerto.TabIndex = 3;
            this.radCerto.TabStop = true;
            this.radCerto.Text = "Kuroko";
            this.radCerto.UseVisualStyleBackColor = true;
            // 
            // radErrado
            // 
            this.radErrado.AutoSize = true;
            this.radErrado.Location = new System.Drawing.Point(6, 97);
            this.radErrado.Name = "radErrado";
            this.radErrado.Size = new System.Drawing.Size(80, 33);
            this.radErrado.TabIndex = 2;
            this.radErrado.TabStop = true;
            this.radErrado.Text = "Goku";
            this.radErrado.UseVisualStyleBackColor = true;
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
            this.pictureBox1.BackgroundImage = global::Aula11_Quiz.Properties.Resources._4c7816c7ea2164fe5ab89d39b0eb0886ed7706e0v2_00;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(519, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 221);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmQuestao3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 270);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuestao3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuestao3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radErrado3;
        private System.Windows.Forms.RadioButton radErrado2;
        private System.Windows.Forms.RadioButton radCerto;
        private System.Windows.Forms.RadioButton radErrado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}