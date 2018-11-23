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
    public partial class frmInicio : Form
    {

        public frmInicio()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string sexo="";
            string nome = txtNome.Text;


            if (radMasculino.Checked == true)
            {
               sexo = "bem vindo ";
            }
            else if(radFemino.Checked == true)
            {
                sexo = "bem vinda ";
            }
            Form saudacao = new frmSaudacao(nome,sexo);
            saudacao.Show();
            this.Hide();
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
