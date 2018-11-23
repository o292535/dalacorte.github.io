namespace Aula8_Lacos
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstFor = new System.Windows.Forms.ListBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.lstWhile = new System.Windows.Forms.ListBox();
            this.btnDo = new System.Windows.Forms.Button();
            this.lstDo = new System.Windows.Forms.ListBox();
            this.pgbWhile = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pgbFor = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loops";
            // 
            // lstFor
            // 
            this.lstFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFor.FormattingEnabled = true;
            this.lstFor.ItemHeight = 31;
            this.lstFor.Location = new System.Drawing.Point(56, 85);
            this.lstFor.Name = "lstFor";
            this.lstFor.Size = new System.Drawing.Size(193, 283);
            this.lstFor.TabIndex = 1;
            // 
            // btnFor
            // 
            this.btnFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFor.Location = new System.Drawing.Point(56, 408);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(193, 44);
            this.btnFor.TabIndex = 2;
            this.btnFor.Text = "for";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhile.Location = new System.Drawing.Point(269, 407);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(193, 44);
            this.btnWhile.TabIndex = 4;
            this.btnWhile.Text = "while";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // lstWhile
            // 
            this.lstWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWhile.FormattingEnabled = true;
            this.lstWhile.ItemHeight = 31;
            this.lstWhile.Location = new System.Drawing.Point(269, 84);
            this.lstWhile.Name = "lstWhile";
            this.lstWhile.Size = new System.Drawing.Size(193, 283);
            this.lstWhile.TabIndex = 3;
            // 
            // btnDo
            // 
            this.btnDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDo.Location = new System.Drawing.Point(485, 407);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(193, 44);
            this.btnDo.TabIndex = 6;
            this.btnDo.Text = "do..while";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // lstDo
            // 
            this.lstDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDo.FormattingEnabled = true;
            this.lstDo.ItemHeight = 31;
            this.lstDo.Location = new System.Drawing.Point(485, 84);
            this.lstDo.Name = "lstDo";
            this.lstDo.Size = new System.Drawing.Size(193, 283);
            this.lstDo.TabIndex = 5;
            // 
            // pgbWhile
            // 
            this.pgbWhile.Location = new System.Drawing.Point(269, 373);
            this.pgbWhile.Name = "pgbWhile";
            this.pgbWhile.Size = new System.Drawing.Size(193, 27);
            this.pgbWhile.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(485, 373);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(193, 27);
            this.progressBar1.TabIndex = 8;
            // 
            // pgbFor
            // 
            this.pgbFor.Location = new System.Drawing.Point(56, 375);
            this.pgbFor.Name = "pgbFor";
            this.pgbFor.Size = new System.Drawing.Size(193, 27);
            this.pgbFor.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(732, 514);
            this.Controls.Add(this.pgbFor);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pgbWhile);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.lstDo);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.lstWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.lstFor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstFor;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.ListBox lstWhile;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.ListBox lstDo;
        private System.Windows.Forms.ProgressBar pgbWhile;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar pgbFor;
    }
}

