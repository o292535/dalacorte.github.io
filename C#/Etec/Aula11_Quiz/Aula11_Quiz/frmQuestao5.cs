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
    public partial class frmQuestao5 : Form
    {
        int certo;
        public frmQuestao5(int c)
        {
            certo = c;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radCerto.Checked == false && rasdsa.Checked == false && ss.Checked == false && radErrado.Checked == false)
            {
                MessageBox.Show("Selecione uma alternativa", "Alerta");

            }
            else
            {
                if (radCerto.Checked == true)
                {
                    certo++;
                }

                Form questao6 = new frmQuestao6(certo);
                questao6.Show();
                this.Close();
            }
        }
    }
}
