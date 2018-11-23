using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula8DesafioFudido
{
    public partial class Form1 : Form
    {
        int n1=0, n2=0, n3=0, i = 0, limp=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(txtN1.Text);
            n2 = Convert.ToInt32(txtN2.Text);
            n3 = Convert.ToInt32(txtN3.Text);
            pb.Minimum = 0;
            pb.Maximum = 100;
            while (n1 < n2) 
            {
                i++;
                pb.Value = i;
                listBox.Items.Add(i);
                listBox.SelectedItem = i;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "1";
            txtN2.Text = "100";
            listBox.Text = "1";
            pb.Value = limp;
        }
    }
}
