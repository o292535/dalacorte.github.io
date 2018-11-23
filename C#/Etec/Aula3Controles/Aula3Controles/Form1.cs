using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula3Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            string Texto = txtCopiar.Text;
            lblResultado.Text = Texto;
            lblResultado.ForeColor = Color.Red;
        }

        private void btnLimparV_Click(object sender, EventArgs e)
        {
            txtCopiar.Text = string.Empty;
            txtResposta.Text = string.Empty;
            lblResultado.Text = "Ensira Algo";
            lblResultado.ForeColor = Color.Pink; 
        }

        private void txtResposta_TextChanged(object sender, EventArgs e)
        {
            txtCopiar.Text = txtResposta.Text;
    
        }

        private void txtCopiar_TextChanged(object sender, EventArgs e)
        {
            txtResposta.Text = txtCopiar.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
