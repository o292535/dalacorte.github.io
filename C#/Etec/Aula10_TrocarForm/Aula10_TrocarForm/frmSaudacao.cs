using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula10_TrocarForm
{
    public partial class frmSaudacao : Form
    {
        string nome;
        string sexo;

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public frmSaudacao(string n,string s)
        {
            nome = n;
            sexo = s;
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form inicio = new frmInicio();
            inicio.Show();
            this.Hide();
        }

        private void frmSaudacao_Load(object sender, EventArgs e)
        {

            lblNome.Text = sexo + nome;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quer Realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Fechar Aplicação
                Application.Exit();
            }
        }
    }
}
