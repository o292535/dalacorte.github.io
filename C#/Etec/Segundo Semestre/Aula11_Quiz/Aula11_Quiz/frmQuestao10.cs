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
    public partial class frmQuestao10 : Form
    {
        int certo;
        public frmQuestao10(int c)
        {
            certo = c;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (radCerto.Checked == false && fsasafsfa.Checked == false && sasad.Checked == false && fff.Checked == false)
                {
                    MessageBox.Show("Selecione uma alternativa", "Alerta");

                }
                else
                {
                    if (radCerto.Checked == true)
                    {
                        certo++;
                    }

                    Form resultado = new frmResultado(certo);
                    resultado.Show();
                    this.Close();
                }
            }

        }
    }
}
