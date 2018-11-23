using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula5_Notacao
{
    public partial class frmNatacao : Form
    {
        public frmNatacao()
        {
            InitializeComponent();
        }

        private void frmNatacao_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txtIdade.Text);
            string nome = txtNome.Text;

            if (idade <= 10) {
                lblResposta.Text = nome+" Você esta na categoria"+" Infatil";
                pictureBox1.Image = Properties.Resources.Infantil;
            }
            if (idade >= 11) {
                lblResposta.Text = nome+" Voce esta na categoria"+" Juvenil";
                pictureBox1.Image = Properties.Resources.juvenil;
            }
            if (idade >= 18) {
                lblResposta.Text = nome+" voce esta na categoria"+" Adulto";
                pictureBox1.Image = Properties.Resources.Adulto;
            }
            if (idade >= 60) {
                lblResposta.Text = nome+" Voce esta na Categoria"+" Senior";
                pictureBox1.Image = Properties.Resources.Senior;
            }
            if (idade < 5) {
                lblResposta.Text = nome+" Voce esta"+" Fora das Categorias";
                pictureBox1.Image = Properties.Resources.fora_de_classe;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                this.Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdade.Text = string.Empty;
            txtNome.Text = string.Empty;
            pictureBox1.Image = null;
            lblResposta.Text = string.Empty;
        }

        private void lblResposta_Click(object sender, EventArgs e)
        {

        }
    }
}
