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
    public partial class frmQuestao6 : Form
    {
        int certo;
        public frmQuestao6(int c)
        {
            certo = c;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (radErrados.Checked == false && rasdsa.Checked == false && ss.Checked == false && radCerto.Checked == false)
                {
                    MessageBox.Show("Selecione uma alternativa", "Alerta");

                }
                else
                {
                    if (radCerto.Checked == true)
                    {
                        certo++;
                    }

                    Form questao7 = new frmQuestao7(certo);
                    questao7.Show();
                    this.Close();
                }
            }
        }
    }
}
