using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula11_Quiz
{
    public partial class frmResultado : Form
    {
        int certo;
        public frmResultado(int c)
        {
            certo = c;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void frmResultado_Load(object sender, EventArgs e)
        {
            label1.Text = "Voce Acertou: " + certo.ToString();
            int errado = 10 - certo;
            label2.Text = "Voce Errou: " + errado.ToString();
            label3.Text = "Sua Porcentagem de acerto foi de: " + certo * 10 + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
