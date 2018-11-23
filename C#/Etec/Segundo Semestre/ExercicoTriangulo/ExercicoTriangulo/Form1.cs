using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExercicoTriangulo
{
    public partial class Triangulo : Form
    {
        public Triangulo()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLado1.Text = null;
            txtLado2.Text = null;
            txtLado3.Text = null;
            lblResposta.Text = null;
            picImagem = null;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtLado1.Text == ""){
                lblResposta.Text = "Digite o Primeiro Valor";
            }
            else if (txtLado2.Text == "")
            {
                lblResposta.Text = "Digite o Segundo Valor";
            }
            else if (txtLado3.Text == "")
            {
                lblResposta.Text = "Digite o Terceiro valor";
            }

            else
            {
            double l1, l2, l3;
            l1 = Convert.ToDouble(txtLado1.Text);
            l2 = Convert.ToDouble(txtLado2.Text);
            l3 = Convert.ToDouble(txtLado3.Text);

            if (l1 == l2 || l1 != l3 || l2 == l3 || l1 != l2)
            {
                lblResposta.Text = "É um isosceles";
                picImagem.Image = Properties.Resources.isosceles;
            }
            if (l1 != l2 && l1 != l3 && l2 != l3)
            {
                lblResposta.Text = "É um escaleno";
                picImagem.Image = Properties.Resources.escaleno;

            }
            if (l3 == l2 && l2 == l3 && l1 == l2)
            {
                lblResposta.Text = "É um equilatero";
                picImagem.Image = Properties.Resources.equilatero;

            }}
        }

        private void picImagem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblLado1_Click(object sender, EventArgs e)
        {

        }

        private void lblLado2_Click(object sender, EventArgs e)
        {

        }

        private void lblLado3_Click(object sender, EventArgs e)
        {

        }

        private void Triangulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)) || (Char.IsPunctuation(e.KeyChar)) || (Char.IsSymbol(e.KeyChar)))
            {
                e.Handled = true; //Não deixa a ação ser concluida
                MessageBox.Show("Apenas Números", "Atenção");//Caixa de Aviso
            }
        }
    }
}
