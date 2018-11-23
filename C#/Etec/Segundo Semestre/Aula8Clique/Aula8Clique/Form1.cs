using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula8Clique
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int clique;
        int i;
        int tempo = 10;
        private void btnClique_Click(object sender, EventArgs e)
        {
            clique++;
            listBox.SelectedItem = clique;
            if (clique == 1)
            {
                listBox.Items.Add(clique + " Lindo Balão Azul");
            }
            else
            {
                listBox.Items.Add(clique + " Lindos Balãos Azuis");
            }
            listBox.SelectedIndex = clique - 1;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            clique = 0;
        }

        private void chkAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutomatico.Checked == true)
            {
                tmrClique.Enabled = true;
            }
        }

        private void tmrClique_Tick(object sender, EventArgs e)
        {
            clique++;
            listBox.SelectedItem = clique;
            if (clique == 1)
            {
                listBox.Items.Add(clique + " Lindo Balão Azul");
            }
            else
            {
                listBox.Items.Add(clique + " Lindos Balãos Azuis");
            }
            listBox.SelectedIndex = clique - 1;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o programa ?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tmrFechar.Enabled = true;
            }
            lblFechar.Visible = true;
        }

        private void tmrFechar_Tick(object sender, EventArgs e)
        {
            lblFechar.Text = "O programa fechará em: " + tempo-- + " segundos";
            if (tempo < 0)
            {
                this.Close();
            }
        }
    }
}
