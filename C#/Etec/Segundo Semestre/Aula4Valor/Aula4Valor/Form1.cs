using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula4Valor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {

            if (txt.Text == "" || txt.Text =="")
            {
                lbl.Text = "Digite um numero";
            }
            else
            {
                int num = int.Parse(txt.Text);
                if (num > 0)
                {
                    lbl.Text = "O valor " + num + " é positivo";
                    pictureBox1.Image = Properties.Resources.Killuakamikamikami;
                }

                if (num < 0)
                {
                    lbl.Text = "O valor " + num + " é negativo";

                    pictureBox1.Image = Properties.Resources.I_crossed_the_limit_lolol;
                }
                else if (num == 0)
                {
                    lbl.Text = "O valor " + num + " é neutro";

                    pictureBox1.Image = Properties.Resources.blueliquidwaves_thx_mr_color;
                }
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lbl.Text = string.Empty;
            txt.Text = string.Empty;
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
