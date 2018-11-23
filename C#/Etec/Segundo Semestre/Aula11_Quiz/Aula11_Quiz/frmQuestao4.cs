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
    public partial class frmQuestao4 : Form
    {
        int certo;
        public frmQuestao4(int c)
        {
            certo = c;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radCerto.Checked == false && radErraddo.Checked == false && radmterrado.Checked == false && radErrado3.Checked == false)
            {
                MessageBox.Show("Selecione uma alternativa", "Alerta");

            }
            else
            {
                if (radCerto.Checked == true)
                {
                    certo++;
                }

                Form questao5 = new frmQuestao5(certo);
                questao5.Show();
                this.Close();
            }
        }
    }
}
