using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula8Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            pbFor.Minimum = 1;
            pbFor.Maximum = 10;
            int i = 0;
            for (i = 0; i < 10;) 
            {
                i++;
                pbFor.Value = i;
                listBox1.Items.Add(i);
                listBox1.SelectedItem = i;
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int i=0;
            pbWhile.Minimum = 1;
            pbWhile.Maximum = 100;
            while (i < 100) 
            {
                i++;
                pbWhile.Value = i;
                listBox2.Items.Add(i);
                listBox2.SelectedItem = i;
            }   
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int i = 1;
            pbDoWhile.Minimum = 1;
            pbDoWhile.Maximum = 1000;
            do
            {
                pbDoWhile.Value = i;
                i++;
                listBox3.Items.Add(i);
                listBox2.SelectedItem = i;
            } while (i < 1000);
        }
    }
}
