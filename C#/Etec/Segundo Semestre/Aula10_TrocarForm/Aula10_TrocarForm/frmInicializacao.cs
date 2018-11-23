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
    public partial class frmInicializacao : Form
    {
        int tempo = 5;
        public frmInicializacao()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            lblTempo.Text = "o programa sera inciado em " + tempo--;
         

            if (tempo < 0) {
                this.Hide();
                timer1.Enabled = false;
                Form Cadastrar = new frmCadastro();
                Cadastrar.Show();
                this.Hide();

            }
        }

        private void frmInicializacao_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            pbTempo.Minimum = 0;
            pbTempo.Maximum = 5;
           

          

        }
    }
}
