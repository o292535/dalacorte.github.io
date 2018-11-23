using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula8_Clique
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int clique = 0;
        private void btnClique_Click(object sender, EventArgs e)
        {
            clique++;
            //Adicionando um valor na ListBox
            if (clique == 1)
            {
                //Singular
                lstCliques.Items.Add(clique + " Clique");
            }
                //Plural
            else { lstCliques.Items.Add(clique + " Cliques"); }

            //Selecionar o índice
            lstCliques.SelectedIndex = clique - 1;
            
          
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpar os Itens da ListBox
            lstCliques.Items.Clear();
            clique = 0;
        }

        private void tmrClique_Tick(object sender, EventArgs e)
        {
            //Timer (código do Botão)

            clique++;
            //Adicionando um valor na ListBox
            if (clique == 1)
            {
                //Singular
                lstCliques.Items.Add(clique + " Clique");
            }
            //Plural
            else { lstCliques.Items.Add(clique + " Cliques"); }

            //Selecionar o índice
            lstCliques.SelectedIndex = clique - 1;
        }

        private void chkAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            //Habilitar o Timer
            if (chkAutomatico.Checked == true)
            {
                tmrClique.Enabled = true;
            }

            //Desebilitar o Timer
            if (chkAutomatico.Checked == false)
            {
                tmrClique.Enabled = false;
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Habilitar Timer Fechar
            if (MessageBox.Show("Deseja fechar o programa?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tmrFechar.Enabled = true;
            }
        }
            int fechar=10;
        private void tmrFechar_Tick(object sender, EventArgs e)
        {
            //Timer para fechar o programa
            lblFechar.Visible = true;
            lblFechar.Text = "O program fechará em " + fechar + " segundos";
            fechar--;
            if (fechar < 0)
            {
                this.Close();
            }
        }

        
    }
}
