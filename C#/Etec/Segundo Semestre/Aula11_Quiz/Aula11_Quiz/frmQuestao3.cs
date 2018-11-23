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
    public partial class frmQuestao3 : Form
    {
        int certo;
        public frmQuestao3(int c)
        {
            certo = c;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radCerto.Checked == false && radErrado.Checked == false && radErrado2.Checked == false && radErrado3.Checked == false)
            {
                MessageBox.Show("Selecione uma alternativa", "Alerta");

            }
            else
            {
                if (radCerto.Checked == true)
                {
                    certo++;
                }

                Form questao4 = new frmQuestao4(certo);
                questao4.Show();
                this.Close();
            }
        }
    }
}
