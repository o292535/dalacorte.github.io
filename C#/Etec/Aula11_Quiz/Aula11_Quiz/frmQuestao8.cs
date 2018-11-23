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
    public partial class frmQuestao8 : Form
    {
        int certo;
        public frmQuestao8(int c)
        {
            certo = c;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (radCerto.Checked == false && fsasafsfa.Checked == false && ss.Checked == false && fff.Checked == false)
                {
                    MessageBox.Show("Selecione uma alternativa", "Alerta");

                }
                else
                {
                    if (radCerto.Checked == true)
                    {
                        certo++;
                    }

                    Form questao9 = new frmQuestao9(certo);
                    questao9.Show();
                    this.Close();
                }
            }

        }
    }
}
