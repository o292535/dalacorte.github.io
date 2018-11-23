using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula4Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            if (txtnota1.Text == "")
            {
                lblresp.Text = "Digite a 1 Nota";
            }
            else if (txtnota2.Text == "")
            {
                lblresp.Text = "Digite a 2 Nota";
            }
            else if (txtFreq.Text == "")
            {
                lblresp.Text = "Digite a Frequencia";
            }
            else
            {
                double frequencia = double.Parse(txtFreq.Text);
                double nota1 = double.Parse(txtnota1.Text);
                double nota2 = double.Parse(txtnota2.Text);
                double media = (nota1 + nota2) / 2;

                if (media >= 7 && frequencia >= 75)
                {
                    lblresp.Text = "Aprovado " + media;
                    lblresp.BackColor = Color.Green;
                    pictureBox1.Image = Properties.Resources.download;
                }
                else if (media < 5 || frequencia < 75)
                {
                    lblresp.Text = "Reprovado " + media;
                    pictureBox1.Image = Properties.Resources._185193_reprovado;
                    lblresp.BackColor = Color.Red;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.Apresentao1_tb;
                    lblresp.Text = "Recuperação " + media;
                    lblresp.BackColor = Color.Yellow;
                }

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblresp.Text = string.Empty;
            txtFreq.Text = string.Empty;
            txtnota1.Text = string.Empty;
            txtnota2.Text = string.Empty;
            txtnota1.Focus();
        }
    }
}
