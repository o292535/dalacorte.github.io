using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula5Notacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Categoria_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = int.Parse(txtIdade.Text);
            if (idade > 5)
            {
                txtResposta.Text = "Infantil " + nome;
                pctBox.Image = Properties.Resources.w;
            }
            if (idade <= 10)
            {
                txtResposta.Text = "Infantil " + nome;
                pctBox.Image = Properties.Resources.w;
            }
            if (idade >= 11)
            {
                txtResposta.Text = "Juvenil " + nome;
                pctBox.Image = Properties.Resources.w;
            }
            if (idade <= 17)
            {
                txtResposta.Text = "Juvenil " + nome;
                pctBox.Image = Properties.Resources.w;
            }
            if (idade >= 18)
            {
                txtResposta.Text = "Adulto " + nome;
                pctBox.Image = Properties.Resources.w;
            }
            if (idade <= 59)
            {
                txtResposta.Text = "Adulto" + nome;
                pctBox.Image = Properties.Resources.w;
            }
            if (idade >= 60)
            {
                txtResposta.Text = "Senior " + nome;
                pctBox.Image = Properties.Resources.w;
            }
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            pctBox = null;
        }

        private void sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o programa?", "Encerrando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { this.Close(); } 
        }

    }
}
