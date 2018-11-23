namespace Aula6_Valores
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
            this.lblResp = new System.Windows.Forms.Label();
            this.txtterceiro = new System.Windows.Forms.TextBox();
            this.txtsegundo = new System.Windows.Forms.TextBox();
            this.txtprimeiro = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResp);
            this.groupBox1.Controls.Add(this.txtterceiro);
            this.groupBox1.Controls.Add(this.txtsegundo);
            this.groupBox1.Controls.Add(this.txtprimeiro);
            this.groupBox1.Controls.Add(this.btnVerificar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblResp
            // 
            this.lblResp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResp.Enabled = false;
            this.lblResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.ForeColor = System.Drawing.Color.Maroon;
            this.lblResp.Location = new System.Drawing.Point(0, 242);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(418, 46);
            this.lblResp.TabIndex = 7;
            this.lblResp.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtterceiro
            // 
            this.txtterceiro.Location = new System.Drawing.Point(253, 180);
            this.txtterceiro.Name = "txtterceiro";
            this.txtterceiro.Size = new System.Drawing.Size(159, 38);
            this.txtterceiro.TabIndex = 6;
            this.txtterceiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtterceiro_KeyPress);
            // 
            // txtsegundo
            // 
            this.txtsegundo.Location = new System.Drawing.Point(253, 136);
            this.txtsegundo.Name = "txtsegundo";
            this.txtsegundo.Size = new System.Drawing.Size(159, 38);
            this.txtsegundo.TabIndex = 5;
            this.txtsegundo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtsegundo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsegundo_KeyPress);
            // 
            // txtprimeiro
            // 
            this.txtprimeiro.Location = new System.Drawing.Point(253, 92);
            this.txtprimeiro.Name = "txtprimeiro";
            this.txtprimeiro.Size = new System.Drawing.Size(159, 38);
            this.txtprimeiro.TabIndex = 4;
            this.txtprimeiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprimeiro_KeyPress);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(107, 291);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(147, 44);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Terceiro Número:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo Número:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primeiro Número:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 382);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Valores";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txtterceiro;
        private System.Windows.Forms.TextBox txtsegundo;
        private System.Windows.Forms.TextBox txtprimeiro;
        private System.Windows.Forms.Label lblResp;
    }
}

