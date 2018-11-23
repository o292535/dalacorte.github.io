using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula8_Lacos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            //Sequência de 1 até 10 (FOR)
            for (int i = 1; i <= 5; i++)
            {
                lstFor.Items.Add(i);
                lstFor.SelectedItem = i;
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            // 1 até 100 (WHILE)
            int cont=1;
            while (cont <= 100)
            {
                lstWhile.Items.Add(cont);
                lstWhile.SelectedItem = cont;
                cont+=2;
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            // 1 até 1000
            int num=1;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 1000;

            do{
                lstDo.Items.Add(num);
                lstDo.SelectedItem = num;
                progressBar1.Value = num;
                num++;
            }
            while (num <= 1000);
        }
    }
}
